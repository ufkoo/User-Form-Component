using System.ComponentModel.DataAnnotations;

namespace User.API.Models
{
    public class User
    {

        [Key]

        public  Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Birthdate { get; set; }

        public string City { get; set; }
    }
}
