using DDona.TesteDapper.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.TesteDapper.DomainLayer.Intelligence
{
    public abstract class Base
    {
        protected SismatDB _db;

        public Base()
        {
            _db = new SismatDB("testeDapper");
        }
    }
}
