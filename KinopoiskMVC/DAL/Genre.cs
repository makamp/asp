using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DAL
{
    [DataContract(IsReference = true)]
    public class Genre
    {
        public Genre()
        {
            Films = new HashSet<Film>();
        }
        [Key]
        [DataMember]
        public int GenreID { get; set; }

        [Required]
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string OriginalTitle { get; set; }

        [DataMember]
        public ICollection<Film> Films { get; set; }
    }
}