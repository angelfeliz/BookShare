using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
   public class Purchase
    {

        public Purchase()
        {
            this.books = new HashSet<Book>();            
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        #region navigation property
         public virtual Client clients { get; set; }
         public virtual ICollection<Book> books { get; set; }
        #endregion
    }
}
