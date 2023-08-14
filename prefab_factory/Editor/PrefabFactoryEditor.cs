using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PrefabFactory))]
public class PrefabFactoryEditor : Editor
{
    public override void OnInspectorGUI()
    {
        PrefabFactory prefabFactory = (PrefabFactory)target;

        // Draw default inspector
        DrawDefaultInspector();

        // Add button to generate prefabs
        if (GUILayout.Button("Generate Prefabs"))
        {
            prefabFactory.GeneratePrefabs();
        }
    }
}