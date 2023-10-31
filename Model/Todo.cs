global using System.ComponentModel.DataAnnotations.Schema;
global using System.ComponentModel.DataAnnotations;


namespace ToDO_Desktop_App.Model
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [Column(TypeName = "nvarchar(100)")]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime date { get; set; }
        public priority priority { get; set; }
        public string Imagepath { get; set; }
        public int userId { get; set; }
    }
}
