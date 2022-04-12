using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDelegates
{
    class GenericClass<T>
    {
        int iCount = 0;
        object[] arrName;
        object[] arrSurname;
        int iSize = 0;


        public GenericClass(int iSize)
        {
            arrName = new object[iSize];
            arrSurname = new object[iSize];
            this.iSize = iSize;
        }

        public void push(object Name,object Surname)
        {
            arrName[iCount] = Name;
            arrSurname[iCount] = Surname;
            iCount++;
        }

        public override string ToString()
        {
            object Display = "";

            for (int i = 0; i < iCount; i++)
            {
                Display += "Name :" + arrName[i] +
                    " Surname:" + arrSurname[i]+"\n";
            }

            return (String)Display;
        }

    }
}
