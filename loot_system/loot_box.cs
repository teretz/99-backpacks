using UnityEngine;

public class LootBox : MonoBehaviour
{
    public LootItem[] containedLoot;
    private InventoryManager inventoryManager;

    private void Start()
    {
        inventoryManager = FindObjectOfType<InventoryManager>();
    }

    public void OpenBox()
    {
        // Logic to open the loot box and display contained loot
    }

    public void CollectLoot()
    {
        foreach (LootItem item in containedLoot)
        {
            inventoryManager.AddItem(item);
        }
        Destroy(gameObject); // Destroy the loot box after collecting the loot
    }

    // Additional code for loot box interactions, animations, etc.
}