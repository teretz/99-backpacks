using UnityEngine;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{
    public List<Level> levels;
    public int currentLevelIndex = 0;

    public void StartLevel(int levelIndex)
    {
        currentLevelIndex = levelIndex;
        Level currentLevel = levels[currentLevelIndex];
        // TODO: Initialize level, spawn enemies, set objectives, etc.
    }

    public void CompleteLevel()
    {
        // TODO: Handle level completion, rewards, progression, etc.
    }
}

[System.Serializable]
public class Level
{
    public string name;
    public List<EnemyType> enemyTypes;
    public List<Vector3> enemySpawnPoints;
    public List<Objective> objectives;
    public List<Item> rewards;

    // You can add more properties and methods to represent different level attributes and behaviors
}

[System.Serializable]
public class Objective
{
    public string description;
    public bool isCompleted;
}

[System.Serializable]
public class EnemyType
{
    public string name;
    public int health;
    public int damage;
}
