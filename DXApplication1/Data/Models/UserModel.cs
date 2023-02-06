using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DXApplication1.Data.Models
{

    public class UserModel
    {
        [Required]
        [Browsable(false)]
        public int UserId { get; set; }

        [Display(Name =  "نام" ,Description ="Desc" ,Order =1, GroupName = "Base Info") , ReadOnly(true),
        StringLength(50, MinimumLength = 3, ErrorMessage = "FirstName Length Problem")]
        public string FirstName { get; set; }


        [Display(Name = "نام  خانوادگی", Description = "Desc", Order = 2, GroupName = "Base Info"), ReadOnly(true),
        StringLength(50, MinimumLength = 3, ErrorMessage = "LastName Length Problem")]
        public string LastName { get; set; }

        [Display(Name = "شماره تلفن", Description = "Desc", Order = 4, GroupName = "Base Info"), ReadOnly(true),
        StringLength(12, MinimumLength = 8, ErrorMessage = "Phone Length Problem")]
        public string Phone { get; set; }

        [Display(Name = "ایمیل", Description = "Desc", Order = 3, GroupName = "Info"), ReadOnly(true),
        StringLength(50, MinimumLength = 10, ErrorMessage = "Email Length Problem")]
        public string Email { get; set; }


        [Display(Name = "آدرس", Description = "Desc", Order = 5, GroupName ="Info"), ReadOnly(true),
        StringLength(1000, MinimumLength = 10, ErrorMessage = "Phone Length Problem")]
        public string Address { get; set; }
        public IEnumerable<AccessModel> UserAccess { get; set; }
    }
}
