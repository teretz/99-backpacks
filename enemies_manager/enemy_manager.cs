using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemyHealth;
    public int enemyDamage;

    // Manages enemy types, health, and damage, and provides functionality to spawn enemies

    public void SpawnEnemy(Vector3 position)
    {
        // Instantiate enemy from prefab
        GameObject enemy = Instantiate(enemyPrefab, position, Quaternion.identity);
        enemy.GetComponent<Enemy>().SetHealth(enemyHealth);
        enemy.GetComponent<Enemy>().SetDamage(enemyDamage);
    }

    // Additional methods for managing enemies can be added here
}
