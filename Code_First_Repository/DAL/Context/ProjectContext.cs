using Code_First_Repository.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Repository.DAL.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext() // ctor
        {
            Database.Connection.ConnectionString = "Server=.;Database=CodeFirst;Trusted_Connection=true";
        }
        public DbSet<AppUser> Kullanicilar { get; set; }
        public DbSet<Product> Urunler { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
        // BaseEntity, DbSet olarak yazılmak zorunda değildir.
    }
}
/* Nuget Package Manager ile Entity Framework projeye eklenir.
   Dal klasörü altında Context ve Entity klasörleri oluşturulur.
   Entity klasörü altına tablo olacak Classlar yazılır.
   Context klasörü altına ProjectContext isimli dosya açılır ve context class'ı yazılır.
   Context class'ı DbContext(System.Data.Entity)'i miras alır.
   Tablo olmasını istediğimiz classlar "public DbSet<....> ... (get; set;) formatında yazılır.
   Nuget Console açılarak "enable-migrations" yazılır.
   update-database denir.
*/