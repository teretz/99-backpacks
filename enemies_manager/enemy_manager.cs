using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab; // Placeholder for enemy prefab
    public int enemyHealth;
    public int enemyDamage;

    // Manages enemy types, health, and damage, and provides functionality to spawn enemies
    // TODO: Implement enemies management system

    public void SpawnEnemy(Vector3 position)
    {
        // Instantiate enemy from prefab
        Instantiate(enemyPrefab, position, Quaternion.identity);
    }
}
