const PrefabFactory = require('./prefab_factory');
const SaveSystem = require('./save_system');

class UnityIntegration {
  constructor() {
    this.prefabFactory = new PrefabFactory();
    this.saveSystem = new SaveSystem('./saves');
  }

  createPrefab(type, properties) {
    try {
      this.prefabFactory.createPrefab(type, properties);
    } catch (error) {
      console.error(error.message);
    }
  }

  getPrefab(type) {
    try {
      return this.prefabFactory.getPrefab(type);
    } catch (error) {
      console.error(error.message);
    }
  }

  savePlayer(playerId, playerData) {
    try {
      this.saveSystem.savePlayer(playerId, playerData);
    } catch (error) {
      console.error(error.message);
    }
  }

  loadPlayer(playerId) {
    try {
      return this.saveSystem.loadPlayer(playerId);
    } catch (error) {
      console.error(error.message);
    }
  }
}

module.exports = UnityIntegration;

// Example Usage
const unityIntegration = new UnityIntegration();
unityIntegration.createPrefab('sword', { damage: 10, rarity: 'common' });
unityIntegration.savePlayer('player1', { health: 100, level: 1, inventory: ['sword'] });
const playerData = unityIntegration.loadPlayer('player1');