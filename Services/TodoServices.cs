public class TodoService
{
    private List<Item> _todos = new List<Item>();

    public Item Add(Item item)
    {
        var newItem = new Item(item.Name, item.Status);
        _todos.Add(newItem);
        return newItem;
    }

    public List<Item> GetAll()
    {
        return _todos;
    }

    public Item? Get(string id)
    {
        return _todos.FirstOrDefault(_ => _.Id.Equals(id, 
                        StringComparison.OrdinalIgnoreCase));
    }
}