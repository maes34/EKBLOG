using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class References : CoreEntity
    {
        public string name { get; set; } = string.Empty;
        public string position { get; set; } = string.Empty;
        public string photo_url { get; set; } = string.Empty;
    }
}
