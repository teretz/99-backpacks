public class LootItem
{
    public string Name { get; set; }
    public int Rarity { get; set; }
    public string Description { get; set; }

    public LootItem(string name, int rarity, string description)
    {
        Name = name;
        Rarity = rarity;
        Description = description;
    }

    // Additional properties, methods, and logic can be added here
}