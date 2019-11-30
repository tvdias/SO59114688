using Microsoft.AspNetCore.Identity;

namespace SO59114688.Models
{
    public class User : IdentityUser
    {
        public string FirastName { get; set; }
        public string LastName { get; set; }
        public string LastNumber { get; set; }
        public string Gander { get; set; }

        //public Language PrefairdLanguage { get; set; }
        public string Themapnail { get; set; }

        //public Address DefaultAddress { get; set; }
        //public Store Store { get; set; }
        public int Imei { get; set; }
    }
}