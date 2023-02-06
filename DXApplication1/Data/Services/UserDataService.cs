using DXApplication1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Data.Services
{
    public class UserDataService
    {
        public static IEnumerable<UserModel> GetData()
        {
            return new List<UserModel>()
            {
                new UserModel()
                {
                    UserId = 1,
                    FirstName = "Omid 01",
                    LastName = "Dadvar 01",
                    Phone = "+98-912456789 01",
                    Email = "dadvar@tazarv.com 01",
                    Address = "aaaaaabbbbbbcccccccccccccccc 01"
                },
                new UserModel()
                {
                    UserId = 2,
                    FirstName = "Omid 02",
                    LastName = "Dadvar 02",
                    Phone = "+98-912456789 02",
                    Email = "dadvar@tazarv.com 02",
                    Address = "aaaaaabbbbbbcccccccccccccccc 02"
                },
                new UserModel()
                {
                    UserId = 3,
                    FirstName = "Omid 03",
                    LastName = "Dadvar 03",
                    Phone = "+98-912456789 03",
                    Email = "dadvar@tazarv.com 03",
                    Address = "aaaaaabbbbbbcccccccccccccccc 03"
                },
                new UserModel()
                {
                    UserId = 4,
                    FirstName = "Omid 04",
                    LastName = "Dadvar 04",
                    Phone = "+98-912456789 04",
                    Email = "dadvar@tazarv.com 04",
                    Address = "aaaaaabbbbbbcccccccccccccccc 05"
                },
                new UserModel()
                {
                    UserId = 5,
                    FirstName = "Omid 05",
                    LastName = "Dadvar 05",
                    Phone = "+98-912456789 05",
                    Email = "dadvar@tazarv.com 05",
                    Address = "aaaaaabbbbbbcccccccccccccccc 05"
                },
                new UserModel()
                {
                    UserId = 6,
                    FirstName = "Omid 06",
                    LastName = "Dadvar 06",
                    Phone = "+98-912456789 06",
                    Email = "dadvar@tazarv.com 06",
                    Address = "aaaaaabbbbbbcccccccccccccccc 06"
                },
                new UserModel()
                {
                    UserId = 7,
                    FirstName = "Omid 07",
                    LastName = "Dadvar 07",
                    Phone = "+98-912456789 07",
                    Email = "dadvar@tazarv.com 07",
                    Address = "aaaaaabbbbbbcccccccccccccccc 07"
                },
                new UserModel()
                {
                    UserId = 8,
                    FirstName = "Omid 08",
                    LastName = "Dadvar 08",
                    Phone = "+98-912456789 08",
                    Email = "dadvar@tazarv.com 08",
                    Address = "aaaaaabbbbbbcccccccccccccccc 08",
                    UserAccess = new List<AccessModel>
                    {
                        new AccessModel()
                        {
                            AccessId = 7,
                            AccessName = "Write on the wall"
                        },
                        new AccessModel()
                        {
                            AccessId = 10,
                            AccessName = "Read god damn book"
                        }
                    }
                }
            };
        }
    }
}
