using System.ComponentModel.DataAnnotations;

namespace notebook.Data
{
    public class Note
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
