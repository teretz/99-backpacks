using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

public class SaveManager : MonoBehaviour
{
    private string savePath;

    private void Start()
    {
        savePath = Path.Combine(Application.persistentDataPath, "save.json");
    }

    public void SaveGame(PlayerManager playerManager, InventoryManager inventoryManager)
    {
        SaveData saveData = new SaveData(playerManager, inventoryManager);
        string json = JsonConvert.SerializeObject(saveData);
        File.WriteAllText(savePath, json);
    }

    public void LoadGame(PlayerManager playerManager, InventoryManager inventoryManager)
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            SaveData saveData = JsonConvert.DeserializeObject<SaveData>(json);
            saveData.ApplyTo(playerManager, inventoryManager);
        }
    }
}

[System.Serializable]
public class SaveData
{
    public string playerName;
    public int level;
    public int health;
    public int experience;
    public Dictionary<string, Item> inventory;

    public SaveData(PlayerManager playerManager, InventoryManager inventoryManager)
    {
        playerName = playerManager.playerName;
        level = playerManager.level;
        health = playerManager.health;
        experience = playerManager.experience;
        inventory = inventoryManager.inventory;
    }

    public void ApplyTo(PlayerManager playerManager, InventoryManager inventoryManager)
    {
        playerManager.playerName = playerName;
        playerManager.level = level;
        playerManager.health = health;
        playerManager.experience = experience;
        inventoryManager.inventory = inventory;
    }
}
