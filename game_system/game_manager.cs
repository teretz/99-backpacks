using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState { MainMenu, Playing, GameOver }
    public GameState currentState = GameState.MainMenu;
    public LevelManager levelManager;
    public PlayerManager playerManager;
    public Transform playerSpawnPoint;

    public void StartGame(int levelIndex)
    {
        currentState = GameState.Playing;
        playerManager.SpawnPlayer(playerSpawnPoint.position);
        levelManager.StartLevel(levelIndex);
    }

    public void EndGame()
    {
        currentState = GameState.GameOver;
        // TODO: Implement game over logic, show game over screen, etc.
    }
}
