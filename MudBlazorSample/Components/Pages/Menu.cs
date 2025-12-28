namespace MudBlazorSample.Components.Pages
{
    public class Menu
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsExpanded { get; set; } = true;
        public List<Menu> Children { get; set; } = new();
    }

    public class MenuGroup
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public HashSet<int> MenuIds { get; set; } = new();
    }
}
