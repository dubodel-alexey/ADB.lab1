using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab1.Entities
{
    public class Nationality
    {
        public Nationality()
        {
            Clients = new List<Client>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}