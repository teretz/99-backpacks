class LootManager {
  constructor() {
    this.lootTable = [
      { name: 'sword', damage: 10 },
      { name: 'shield', defense: 5 },
      { name: 'potion', heal: 20 },
      { name: 'arrow', type: 'ammo', quantity: 5 },
      { name: 'bullet', type: 'ammo', quantity: 10 }
    ];
  }

  generateLoot() {
    const randomIndex = Math.floor(Math.random() * this.lootTable.length);
    return this.lootTable[randomIndex];
  }

  dropLoot() {
    const loot = this.generateLoot();
    console.log(`Dropped ${loot.name}.`);
    return loot;
  }
}

module.exports = LootManager;

// Example Usage
const lootManager = new LootManager();
const droppedLoot = lootManager.dropLoot();
console.log(`You found a ${droppedLoot.name}!`);