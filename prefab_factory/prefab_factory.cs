using UnityEngine;
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
            generatedPrefabs.Add(prefab);
        }
    }

    // Additional methods for managing and customizing prefabs
}