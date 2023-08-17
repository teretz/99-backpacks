using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System.Collections.Generic;

public class PrefabFactory : MonoBehaviour
{
    [System.Serializable]
    public class PrefabTemplate
    {
        public string name;
        public GameObject basePrefab;
        public PhysicMaterial physicMaterial;
        public float size;
        public bool isTwoHanded;
    }

    public List<PrefabTemplate> prefabTemplates = new List<PrefabTemplate>();
    public List<GameObject> generatedPrefabs = new List<GameObject>();

    public void GeneratePrefabs()
    {
        foreach (var template in prefabTemplates)
        {
            GameObject prefab = Instantiate(template.basePrefab);
            prefab.name = template.name;
            prefab.GetComponent<Rigidbody>().material = template.physicMaterial;
            prefab.transform.localScale = new Vector3(template.size, template.size, template.size);
            if (template.isTwoHanded) { /* Apply two-handed logic */ }

            AttachGrabbableComponent(prefab); // Attach grabbable component

            generatedPrefabs.Add(prefab);
        }
    }

    private void AttachGrabbableComponent(GameObject prefab)
    {
        // Assuming Grabbable is a component that handles grab functionality
        Grabbable grabbable = prefab.AddComponent<Grabbable>();

        // You can customize the grabbable component here if needed
        // e.g., grabbable.someProperty = someValue;
    }

    public void SaveGeneratedPrefabs()
    {
#if UNITY_EDITOR
        foreach (GameObject prefab in generatedPrefabs)
        {
            string path = "Assets/Prefabs/" + prefab.name + ".prefab";
            PrefabUtility.SaveAsPrefabAsset(prefab, path);
            Debug.Log("Saved prefab: " + path);
        }
#endif
    }

    // Additional methods for managing and customizing prefabs
}