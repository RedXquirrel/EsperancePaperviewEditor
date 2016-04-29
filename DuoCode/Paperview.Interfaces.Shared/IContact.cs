namespace Paperview.Interfaces
{
    public interface IContact
    {
        string Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Url { get; set; }
    }
}