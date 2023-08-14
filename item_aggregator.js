class ItemAggregator {
  constructor() {
    this.items = {};
  }

  createItem(type, properties) {
    const item = { type, ...properties };
    this.items[type] = item;
    // Create a new item of the specified type with given properties
  }

  getItem(type) {
    return this.items[type];
    // Retrieve an item by its type
  }

  getAllItems() {
    return Object.values(this.items);
    // Retrieve all items
  }
}

module.exports = ItemAggregator;

// Example Usage
const itemAggregator = new ItemAggregator();
itemAggregator.createItem('sword', { damage: 10, rarity: 'common' });
itemAggregator.createItem('shield', { defense: 5, rarity: 'rare' });
const allItems = itemAggregator.getAllItems();