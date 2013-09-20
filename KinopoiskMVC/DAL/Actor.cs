using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DAL
{
    [DataContract(IsReference = true)]
    public class Actor
    {
        public Actor()
        {
            Films = new HashSet<Film>();
        }

        [Key]
        [DataMember]
        public int ActorID { get; set; }

        [Required]
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public ICollection<Film> Films { get; set; }
    }
}
