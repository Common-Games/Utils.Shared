#if UNITY_EDITOR
using System;
using System.IO;
using static System.IO.Path;

using System.Runtime.CompilerServices;

using UnityEngine;
using UnityEditor;

using JetBrains.Annotations;

namespace CGTK.Utils.Shared
{

    public static class ScriptableObjectCreator
    {
        private const String _DEFAULT_DIRECTORY = "Assets/";

        [PublicAPI]
        public static T Create<T>(String directory = _DEFAULT_DIRECTORY)
            where T : ScriptableObject
        {
            String __fullPath = Application.dataPath + PathSeparator + directory; 
            if (!Directory.Exists(path: __fullPath))
            {
                Debug.LogWarning(message: $"Directory {Application.dataPath + PathSeparator + directory} doesn't exist");
                directory = "";
            }

            directory = EditorUtility.SaveFilePanel(title: "Save ScriptableObject as...", directory: directory, defaultName: "New " + typeof(T).Name, extension: "asset");
            
            //It assumes you're putting it in a subdirectory of Application.dataPath.
            //But that's the only directory where they make sense, so don't be an idiot.

            if (String.IsNullOrEmpty(value: directory))
            {
                Debug.LogError(message: "NO DIRECTORY SELECTED");
                return null;
            }
            
            directory = directory.Remove(startIndex: 0, count: Application.dataPath.Length - 6); //-6 for "Assets" 

            if (TryCreateInstance(asset: out T __asset))
            {
                Debug.Log(message: $"Created Instance = {directory}");
                
                AssetDatabase.CreateAsset(asset: __asset, path: directory);
                AssetDatabase.Refresh();
                return __asset;
            }
            
            Debug.LogError(message: "ScriptableObject Creation FAILED!!");
            return null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean TryCreateInstance<T>(out T asset)
            where T : ScriptableObject
        {
            asset = ScriptableObject.CreateInstance<T>();
            
            return (asset != null);
        }
    }

}
#endif