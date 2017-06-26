using DDona.TesteDapper.DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.TesteDapper.DomainLayer.Intelligence
{
    public class Person : Base
    {
        public PersonModel Model { get; set; }

        public Person() { }

        public Person(int id)
        {
            string sql = $@"SELECT * FROM PERSON WHERE ID = {id}";
            Model = _db.Get<PersonModel>(sql);
        }
    }
}
