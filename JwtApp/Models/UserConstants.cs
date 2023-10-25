using System.Data;

namespace JwtApp.Models
{
    public class UserConstants
    {


        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { UserName = "jason_admin",EmailAddress = "jason.admin@email.com", Password = "MyPass_word", GivenName = "Jason", Surname = "Bryant", Role = "Administrator" },
            new UserModel() { UserName = "elyse_seller", EmailAddress = "elyse.seller@email.com", Password = "MyPass_word", GivenName = "Elyse", Surname = "Lambert", Role = "Seller" },

        };

    }
}
