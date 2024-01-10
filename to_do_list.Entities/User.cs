using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_do_list.Entities
{
    public class User
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Password { get; set; }
    }
}
