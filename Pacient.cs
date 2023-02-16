using System;
using System.Collections.Generic;
using System.Text;

namespace prr
{
    class Pacient
    {
        private DateTime dateOfBirth;
        private string FIO;


        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        class Initials : Pacient
        {
            public String fio
            {
                get { return fio; }
                set { fio = value; }
            }
        }
    }
}
