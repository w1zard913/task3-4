using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    internal interface IBaseArray : IPrinter
    {
        public abstract void UserFill();
        public abstract void RandomFill();
    }
}
