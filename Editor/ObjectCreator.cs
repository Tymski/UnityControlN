using UnityEditor;

public class ObjectCreator
{
    [MenuItem("Assets/Create Object %n")]
    public static void CreateObject()
    {
        string path = AssetDatabase.GetAssetPath(Selection.activeObject);
        if (path.Contains("Scripts")) EditorApplication.ExecuteMenuItem("Assets/Create/C# Script");
        else if (path.Contains("Scenes")) EditorApplication.ExecuteMenuItem("Assets/Create/Scene");
        else if (path.Contains("Prefabs")) EditorApplication.ExecuteMenuItem("Assets/Create/Prefab");

        if (!string.IsNullOrEmpty(path)) return;

        if (Selection.gameObjects.Length > 1) EditorApplication.ExecuteMenuItem("GameObject/Create Empty Parent");
        else EditorApplication.ExecuteMenuItem("GameObject/Create Empty Child");
    }
}
