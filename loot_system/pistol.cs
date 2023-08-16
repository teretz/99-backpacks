using UnityEngine;

public class Pistol : LootItem
{
    public GameObject PistolPrefab { get; set; }

    public Pistol(string name, int rarity, string description, GameObject pistolPrefab)
        : base(name, rarity, description)
    {
        PistolPrefab = pistolPrefab;
    }

    public void SpawnPistol(Vector3 position)
    {
        Instantiate(PistolPrefab, position, Quaternion.identity);
    }
}