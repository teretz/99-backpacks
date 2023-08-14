using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerManager playerManager;
    public InventoryManager inventoryManager;
    public SaveManager saveManager;
    public LootManager lootManager;
    public EnemyManager enemyManager;
    public PistolTemplate pistolTemplate;

    // Keeps track of the current game in session
    // TODO: Implement game management, including player spawn, levels, rules, etc.

    private void Start()
    {
        InitializeGame();
    }

    private void InitializeGame()
    {
        // Spawn player
        playerManager.SpawnPlayer();

        // Spawn pistol a couple of feet in front of the player
        Vector3 pistolPosition = playerManager.transform.position + new Vector3(0, 0, 2);
        pistolTemplate.SpawnPistol(pistolPosition);

        // TODO: Initialize other game components
    }

    public void SaveGame()
    {
        saveManager.SaveGame(playerManager, inventoryManager);
    }

    public void LoadGame()
    {
        saveManager.LoadGame(playerManager, inventoryManager);
    }
}
