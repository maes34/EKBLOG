using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class UserSkill : CoreEntity
    {
        public string skill_name { get; set; } = string.Empty;
        public string skill_point { get; set; } = string.Empty;
    }
}
