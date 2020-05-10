using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Repository.DAL.Entities
{
    [Table("Users")] // Table Attribute, içerisine yazılmış olan string değeri tablo oluştururken tablo ismi olarak belirleyecektir.
    public class AppUser : BaseEntity
    {
        [MaxLength(30)] // MaxLength, default olarak nvarchar(MAX) olan stringleri belirtilen sayı kadar yer alabileceğini belirleyecektir.
        public string LastName { get; set; }

        [NotMapped] // NotMapped, entity içerisinde var olmasına rağmen Database'de tabloda bir sütun olarak oluşturulmayacaktır.
        public string FullName
        {
            get
            {
                return Name + " " + LastName;
            }
        }

        [Required] // Reference Type olmasına rağmen Required denilerek (Not Null) bir sütun oluşturulabilir.
        public string UserName { get; set; }

        [Required]
        public string password { get; set; }

        public DateTime? BirthDate { get; set; }
        public bool Gender { get; set; }
    }
}