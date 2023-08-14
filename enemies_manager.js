class EnemiesManager {
  constructor() {
    this.enemies = [];
  }

  spawnEnemy(type, location) {
    const enemy = { type, location };
    this.enemies.push(enemy);
    // Spawn a new enemy of the specified type at the given location
  }

  removeEnemy(enemyIndex) {
    this.enemies.splice(enemyIndex, 1);
    // Remove an enemy from the game by its index
  }

  getEnemies() {
    return this.enemies;
    // Retrieve the list of all active enemies in the game
  }
}

module.exports = EnemiesManager;

// Example Usage
const enemiesManager = new EnemiesManager();
enemiesManager.spawnEnemy('zombie', { x: 10, y: 20 });
enemiesManager.spawnEnemy('skeleton', { x: 5, y: 15 });
const activeEnemies = enemiesManager.getEnemies();