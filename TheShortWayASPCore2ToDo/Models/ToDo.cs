using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheShortWayASPCore2ToDo.Models
{
    public class ToDo
    {
        public ToDo()
        {

        }
        [Key]
        public string Id { get; set; }
        public bool Check { get; set; }
        public string Title { get; set; }
        public DateTime DueAt { get; set; }

    }
}

