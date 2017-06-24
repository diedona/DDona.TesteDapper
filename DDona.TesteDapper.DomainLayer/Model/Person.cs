using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.TesteDapper.DomainLayer.Model
{
    public class Person : Base
    {
        #region [ PUBLIC PROPERTIES ]

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        #endregion

        #region [ CTOR ]

        public Person() { }

        public Person(int id)
        {
            #region [ SQL ]
            string sql = $@"SELECT * FROM PERSON WHERE ID = {id}";
            #endregion

            var person = this._db.Get<Person>(sql);
        }

        #endregion

        #region [ PUBLIC METHODS ]



        #endregion
    }
}
