// Inventory Manager

// Function to sort inventory items
function sortInventoryItems(inventory) {
  inventory.sort((a, b) => a.name.localeCompare(b.name));
  return inventory;
}

// TODO: Add other inventory management functions
