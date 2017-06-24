using DDona.TesteDapper.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.TesteDapper.DomainLayer.Model
{
    public abstract class Base
    {
        protected readonly SismatDB _db;

        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public Base()
        {
            _db = new SismatDB("testeDapper");
        }
    }
}
