
using System.Data.Entity;

namespace Logic
{
    public class DropCreate : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var jocke = new ApplicationUser { Firstname = "Jocke", Lastname = "Kniv", Email = "jocke@mail.se", PasswordHash = "Jocke1" };
            var Kungen = new ApplicationUser { Firstname = "Kungen", Lastname = "Knug", Email = "kungen@mail.se", PasswordHash = "Kungen1" };
            var Dicken = new ApplicationUser { Firstname = "Dicken", Lastname = "Dick", Email = "dicken@hotmail.com", PasswordHash = "dicken1" };

            context.Users.Add(jocke);
            context.Users.Add(Kungen);
            context.Users.Add(Dicken);

            context.SaveChanges();
            base.Seed(context);
        }

    }
}
