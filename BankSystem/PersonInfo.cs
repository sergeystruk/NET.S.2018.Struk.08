using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class PersonInfo
    {
        #region Fields

        private string name;
        private string surname;
        private string email;

        #endregion

        #region Construction

        public PersonInfo(string personName, string personSurname, string personEmail)
        {
            name = personName;
            surname = personSurname;
            email = personEmail;
        }

        #endregion
    }
}
