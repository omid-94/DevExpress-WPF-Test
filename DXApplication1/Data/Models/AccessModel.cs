using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Data.Models
{
    public class AccessModel
    {
        [Required]
        public int AccessId { get; set; }
        [StringLength(40)]
        public string AccessName { get; set; }
    }
}
