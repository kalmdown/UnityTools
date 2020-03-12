// Karl Mochel. Mar 2020.
// Updated from: https://docs.unity3d.com/ScriptReference/PrefabUtility.html 
// Put in an Editor folder in your Unity Assets folder.
// Creates a Tools menu item.
// Use it to create Prefab(s) from the selected GameObject(s).
// It will be placed in the root Assets folder.

using UnityEngine;
using UnityEditor;

public class Example
{
    // Creates a new menu item 'Examples > Create Prefab' in the main menu.
    [MenuItem("Tools/Create Prefab")]
    static void CreatePrefab()
    {
        // Keep track of the currently selected GameObject(s)
        GameObject[] objectArray = Selection.gameObjects;

        // Loop through every GameObject in the array above
        foreach (GameObject gameObject in objectArray)
        {
            // Set the path as within the Assets folder,
            // and name it as the GameObject's name with the .Prefab format
            string localPath = "Assets/" + gameObject.name + ".prefab";

            // Make sure the file name is unique, in case an existing Prefab has the same name.
            localPath = AssetDatabase.GenerateUniqueAssetPath(localPath);

            // Create the new Prefab.
            PrefabUtility.SaveAsPrefabAssetAndConnect(gameObject, localPath, InteractionMode.UserAction);
        }
    }

    // Disable the menu item if no selection is in place.
    [MenuItem("Tools/Create Prefab", true)]
    static bool ValidateCreatePrefab()
    {
        return Selection.activeGameObject != null && !EditorUtility.IsPersistent(Selection.activeGameObject);
    }
}