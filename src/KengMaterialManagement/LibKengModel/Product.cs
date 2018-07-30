using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibKengModel
{
    [Table("products", Schema = "public")]
    public class Product
    {
        [Key]
        [Column("id")]
        public int id { get; set; }
        public string name { get; set; }
    }
}
