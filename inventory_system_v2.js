class InventorySystem {
  constructor() {
    this.inventories = {};
  }

  createInventory(playerId) {
    this.inventories[playerId] = [];
    // Create a new inventory for the specified player
  }

  addItem(playerId, item) {
    this.inventories[playerId].push(item);
    // Add an item to the player's inventory
  }

  removeItem(playerId, itemIndex) {
    this.inventories[playerId].splice(itemIndex, 1);
    // Remove an item from the player's inventory
  }

  getInventory(playerId) {
    return this.inventories[playerId];
    // Retrieve the player's inventory
  }
}

module.exports = InventorySystem;

// TODO: Implement new inventory UI
function implementNewInventoryUI(playerId) {
  // Logic to implement the new inventory UI for the specified player
}

// Example Usage
const inventorySystem = new InventorySystem();
inventorySystem.createInventory('player1');
inventorySystem.addItem('player1', { itemId: 'sword', quantity: 1 });