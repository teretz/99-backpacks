using UnityEngine;

public class PistolTemplate : MonoBehaviour
{
    public GameObject pistolPrefab; // Placeholder for pistol prefab

    // Template for pistol items, including damage, magazine size, and fire rate
    // TODO: Implement item templates for weapons

    public void SpawnPistol(Vector3 position)
    {
        // Instantiate pistol from prefab
        Instantiate(pistolPrefab, position, Quaternion.identity);
    }
}
