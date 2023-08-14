const fs = require('fs');

class SaveSystem {
  constructor(filePath) {
    this.filePath = filePath;
  }

  saveGameState(gameState) {
    fs.writeFileSync(this.filePath, JSON.stringify(gameState));
    console.log(`Game state saved to ${this.filePath}.`);
  }

  loadGameState() {
    if (fs.existsSync(this.filePath)) {
      const savedState = fs.readFileSync(this.filePath, 'utf8');
      return JSON.parse(savedState);
    } else {
      console.log(`Save file not found at ${this.filePath}.`);
      return null;
    }
  }
}

module.exports = SaveSystem;

// Example Usage
const saveSystem = new SaveSystem('./savefile.json');
const gameState = { player: { health: 100, level: 5 }, inventory: ['sword', 'potion'] };
saveSystem.saveGameState(gameState);
const loadedState = saveSystem.loadGameState();
console.log(`Loaded game state:`, loadedState);