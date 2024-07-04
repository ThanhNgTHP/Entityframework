using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    public class Comics
    {
        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public int rating { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string summary { get; set; }
        public string avatar { get; set; }
        public string nameOther { get; set; }

        [NotMapped]
        public Chapters Chapters { get; set; }
    }
}
