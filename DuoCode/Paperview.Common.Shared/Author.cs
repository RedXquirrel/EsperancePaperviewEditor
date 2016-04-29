using Paperview.Interfaces;

namespace Paperview.Common
{
    public class Author : IAuthor
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
    }
}