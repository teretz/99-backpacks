function handleItemWeight(inventory) {
  // Logic to handle item weight in the inventory
  let totalWeight = 0;
  inventory.forEach(item => totalWeight += item.weight);
  return totalWeight <= MAX_WEIGHT;
}

// Other inventory system functions