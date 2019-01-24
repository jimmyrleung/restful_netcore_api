using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestfulCoreAPI.Models
{
    public class User
    {
        [Key]
        [Column("id")]
        public long? Id { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("passwd")]
        public string Password { get; set; }
    }
}
