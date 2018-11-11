using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;
using VRTK;

public class EditorRxFromVRTKEvents
{
    [MenuItem("Tools/VRTK to Rx/Create ControllerEvents")]
    public static void CreateControllerEvents()
    {
        CreateEvents(typeof(VRTK_ControllerEvents));
    }

    [MenuItem("Tools/VRTK to Rx/Create All VRTK")]
    public static void CreateIAllVRTK()
    {
        Debug.Log("[VRTK to Rx]Processing from all class ...");

        var folderPath = EditorUtility.SaveFolderPanel("Save", "Assets", "RxVRTK");

        if (string.IsNullOrEmpty(folderPath))
        {
            Debug.Log("[VRTK to Rx]Cancelled Creating");
            return;
        }

        var assemblies = AppDomain.CurrentDomain.GetAssemblies();

        foreach (var assembly in assemblies)
        {
            foreach (var type in assembly.GetTypes().Where(t => t.IsClass && t.Namespace == "VRTK"))
            {
                var events = type.GetEvents();
                if (events.Length > 0)
                {
                    CreateEventsFromALL(type, folderPath);
                }
            }
        }


        Debug.Log("[VRTK to Rx]Created files at " + folderPath);
    }

    private static void CreateEventsFromALL(Type type, string folderPath)
    {
        var sb = CreateEventsStringBuuilder(type);
        WriteFileTemplate(sb, type.Name, folderPath);
    }

    private static void CreateEvents(Type type)
    {
        Debug.Log("[VRTK to Rx]Processing : " + type.Name);
        var sb = CreateEventsStringBuuilder(type);
        WriteFileTemplate(sb, type.Name);
    }

    private static StringBuilder CreateEventsStringBuuilder(Type type)
    {
        var sb = InitFileTemplate(type.Name);
        var events = type.GetEvents();

        foreach (var item in events)
        {
            var attrs = Attribute.GetCustomAttributes(item, typeof(ObsoleteAttribute));
            if (attrs.Length > 0)
            {
                sb.Append(GetObsoleteString(attrs.Last() as ObsoleteAttribute));
                sb.Append(GetPropertyString(type.Name, item.Name, item.EventHandlerType.Name, item.EventHandlerType.GetMethod("Invoke").GetParameters().Last().ParameterType.Name, item.EventHandlerType.GetMethod("Invoke").GetParameters().Length == 1));
            }
            else
            {
                sb.Append(GetPropertyString(type.Name, item.Name, item.EventHandlerType.Name, item.EventHandlerType.GetMethod("Invoke").GetParameters().Last().ParameterType.Name, item.EventHandlerType.GetMethod("Invoke").GetParameters().Length == 1));
            }
        }

        return sb;
    }

    private static StringBuilder InitFileTemplate(string typeName)
    {
        var sb = new StringBuilder();
        sb.Append(@"using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class ");
        sb.Append(GetClassName(typeName));
        sb.Append("\n    {\n");

        return sb;
    }

    private static string GetObsoleteString(ObsoleteAttribute obsoleteAttribute)
    {
        if (obsoleteAttribute == null) return "";

        return "        [Obsolete(\"" + obsoleteAttribute.Message + "\")]";
    }

    private static void WriteFileTemplate(StringBuilder sb, string typeName)
    {
        sb.Append("\n}");
        var filePath = EditorUtility.SaveFilePanel("Save", "Assets", GetClassName(typeName), "cs");

        if (!string.IsNullOrEmpty(filePath))
        {
            File.WriteAllText(filePath, sb.ToString());
            Debug.Log("[VRTK to Rx]Created at " + filePath);
        }
        else
        {
            Debug.Log("[VRTK to Rx]Cancelled Creating");
        }
    }

    private static void WriteFileTemplate(StringBuilder sb, string typeName, string folderPath)
    {
        sb.Append("\n    }");
        sb.Append("\n}");
        File.WriteAllText(folderPath + "/" + GetClassName(typeName) + ".cs", sb.ToString());
    }

    private static string GetPropertyString(string typeName, string eventName, string handlerName, string argsName, bool isSenderOnly = false)
    {
        var sb = new StringBuilder();
        sb.Append(@"
        /// <summary>
        /// Observable ");

        sb.Append(eventName);
        sb.Append(" event");

        sb.Append(@"
        /// </summary>
        /// <param name=""events""></param>
        /// <returns></returns>
");
        sb.Append("        public static IObservable<");
        sb.Append(argsName);
        sb.Append("> ");
        sb.Append(eventName);
        sb.AppendFormat("AsObservable(this {0} events)", typeName);
        sb.AppendLine();
        sb.Append(@"        {
            return Observable.FromEvent<");
        sb.Append(handlerName);
        sb.Append(", ");
        sb.Append(argsName);
        sb.AppendLine(">(");

        if (isSenderOnly)
        {
            sb.AppendLine("                 h => h.Invoke,");
        }
        else
        {
            sb.AppendLine("                 h => (s, e) => h(e),");
        }

        sb.AppendFormat("                 h => events.{0} += h,", eventName);
        sb.AppendLine();
        sb.AppendFormat("                 h => events.{0} -= h);", eventName);
        sb.AppendLine();
        sb.Append("        }");
        sb.AppendLine();
        return sb.ToString();
    }

    private static string GetClassName(string typeName)
    {
        return "Rx" + typeName + "Extension";
    }
}