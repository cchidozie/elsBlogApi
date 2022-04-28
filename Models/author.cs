

namespace elsBlog.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Author")]
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int authorID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string bio { get; set; }

        public string avatar { get; set; }

    }
}

