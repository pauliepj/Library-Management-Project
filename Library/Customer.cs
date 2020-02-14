using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Customer : Book
    {
        //list the customers' full names
        public List <string> CustList()
        {
            string sarahH = "Sarah Hutchins";
            string daveyJ = "Davey Jones";
            string paulM = "Paul Mitchell";
            string bradleyC = "Bradley Cooper";

            List<string> custList = new List<string>();
            custList.Add(sarahH);
            custList.Add(daveyJ);
            custList.Add(paulM);
            custList.Add(bradleyC);

            return custList;
        }
        public void PrintCust(List<string> custList)
        {
            foreach(object o in custList)
            Console.WriteLine(o); 

        }
          
        public List<string> AddCust(string name, List<string> custList)
        {
        
            custList.Add(name);
            return custList;
        }
         
        public void CustData(string name)
        {

            if (name == "Sarah Hutchins")
            {
                Book.BookInfo(123);
            }
            else if (name == "Davey Jones")
            {
                Book.BookInfo(234);
                Book.BookInfo(345);
            }
            else
            {
                Console.WriteLine(name + " has no books checked out");
            }

        }
    }
}
