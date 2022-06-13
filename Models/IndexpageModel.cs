using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_Test_Project.Models
{
    public class IndexpageModel
    {
        public AdminModel AdminModel { get; set; }
        public List<UserModel> usersAgeAbove30 { get; set; }
        public List<UserModel> users { get; set; }
        public UserModel user { get; set; }
    }
}
