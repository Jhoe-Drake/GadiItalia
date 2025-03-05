using Drk.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornitoriApp.Models
{
    public class ActivityTypeDto:Dto
    {
        public bool Checked { get; set; }
        public string Description { get; set; }

        public ActivityTypeDto() { }
        public ActivityTypeDto(int id) : this()
        {
            _id = id;
        }
    }
}
