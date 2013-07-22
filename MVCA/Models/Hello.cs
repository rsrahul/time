using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace MVCA.Models
{
    public class Hello
    {
        public int id
        {
            get;
            set;

        }
        public string name
        {
            get;
            set;

        }
        public string password
        {
            get;
            set;

        }
    }
    public class hellodbcontext : DbContext
    {
        public DbSet<Hello> rahul
        {
            get;
            set;

        }
    }
    public class enter
    {
        [Required]
        [Display(Name = "rahul")]
        public string rahul
        {
            get;
            set;
        }
    
    }
}