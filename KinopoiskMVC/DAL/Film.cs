using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DAL
{
    [DataContract(IsReference = true)]
    public class Film
    {
        public Film()
        {
            Genres = new HashSet<Genre>();
            Actors = new HashSet<Actor>();
        }

        [Key]
        [DataMember]
        public int FilmID { get; set; }

        [Required]
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string OriginalTitile { get; set; }

        [Required]
        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public ICollection<Actor> Actors { get; set; }

        [DataMember]
        public ICollection<Genre> Genres { get; set; }
    }
}
