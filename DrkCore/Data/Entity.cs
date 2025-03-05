using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Drk.Core.Data
{
    public abstract class Dto
    {
        protected int _id;
        

        public int Id { get => _id; private set => _id = value; }
    }
}
