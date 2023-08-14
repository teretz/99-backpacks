class PlayerManager {
  constructor() {
    this.player = {
      level: 1,
      health: 100,
      experience: 0,
      attributes: {
        strength: 10,
        agility: 10,
        intelligence: 10
      }
    };
  }

  gainExperience(exp) {
    this.player.experience += exp;
    console.log(`Gained ${exp} experience points.`);
    this.checkLevelUp();
  }

  checkLevelUp() {
    if (this.player.experience >= this.player.level * 100) {
      this.player.level += 1;
      this.player.experience -= this.player.level * 100;
      console.log(`Leveled up to level ${this.player.level}!`);
    }
  }

  getPlayerStats() {
    console.log('Player Stats:', this.player);
  }
}

module.exports = PlayerManager;

// Example Usage
const playerManager = new PlayerManager();
playerManager.gainExperience(100);
playerManager.getPlayerStats();