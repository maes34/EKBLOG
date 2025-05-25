using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class About : CoreEntity
    {
        public string Title { get; set; } = string.Empty;
        public string PhotoUrl { get; set; } = string.Empty;


    }
}
