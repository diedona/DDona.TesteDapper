using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.TesteDapper.DomainLayer.Model
{
    public class PersonModel : BaseModel
    {
        #region [ PUBLIC PROPERTIES ]

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        #endregion
    }
}
