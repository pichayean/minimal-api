public class Item {
    public Item(string name, string status)
    {
        Id = Guid.NewGuid().ToString();
        Name = name;
        Status = status;
    }

    public string Id { get; set; }
    public string Name { get; set; }
    
    public string Status { get; set; }
}