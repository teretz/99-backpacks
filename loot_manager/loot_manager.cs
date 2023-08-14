using UnityEngine;

public class LootManager : MonoBehaviour
{
    public PrefabFactory prefabFactory;

    public GameObject GetRandomPrefabLoot()
    {
        int randomIndex = Random.Range(0, prefabFactory.generatedPrefabs.Count);
        GameObject selectedPrefab = prefabFactory.generatedPrefabs[randomIndex];
        return selectedPrefab;
    }

    // Additional methods to manage prefabs within the loot system
    // ...

    // Existing loot management code
    // ...
}