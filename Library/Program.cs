using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program : Customer
    {
        static void Main(string[] args)
        {

            Console.WriteLine("For total number of books by branch, type 1. for Customer Data, type 2. To Add a new customer, press 3. ");
            int caseswitch = Convert.ToInt32(Console.ReadLine());
            switch (caseswitch)
            {
                case 1:
                    Console.WriteLine("For the Maplewood branch, press 1. For the Downtown Branch, press 2");
                    int whichBranch = Convert.ToInt32(Console.ReadLine());
                    switch (whichBranch)
                    {
                        case 1:
                            Branch B1 = new Branch();
                            B1.Maplewood(0);
                            break;

                        case 2:
                            Branch B2 = new Branch();
                           // Console.WriteLine("The Downtown branch has " + B2.Downtown() + " books.");
                            break;
                    }
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("for a list of customers, press 1. For specific customer data, type in the name of the customer");
                    string options = Console.ReadLine();
                    if (options == "1")
                    {
                        Customer C2 = new Customer();
                        List <string> listData = C2.CustList();
                        C2.PrintCust(listData);
                        Console.ReadLine();

                    }
                    else
                    {

                        Customer C3 = new Customer();
                        C3.CustData(options);
                        Console.ReadLine();
                    }
                    break;

                case 3:
                    Console.WriteLine("Please enter the full name of the new customer:");
                    string newCust = Console.ReadLine();
                    Customer C1 = new Customer();
                    C1.CustList();
                    List<string> listData1 = C1.AddCust(newCust, C1.CustList());
                    Console.WriteLine("You have added " + newCust + " to the customer list");
                    
                    foreach (object o in listData1)
                        Console.WriteLine(o);
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Please enter an ISBN from the list");
                    Console.WriteLine("123");
                    Console.WriteLine("234");
                    Console.WriteLine("345");
                    Console.WriteLine("456");
                    Console.WriteLine("567");
                    Console.WriteLine("678");
                    Console.WriteLine("789");
                    Console.WriteLine("890");
                    Console.WriteLine("901");
                    Console.WriteLine("102");
                    Console.WriteLine("103");
                    Console.WriteLine("104");
                    Console.WriteLine("105");
                    Console.WriteLine("106");
                    Console.WriteLine("107");
                    Console.WriteLine("108");
                    Console.WriteLine("109");
                    Console.WriteLine("110");
                    Console.WriteLine("111");
                    Console.WriteLine("112");
                    Console.WriteLine("145");
                    Console.WriteLine("156");
                    Console.WriteLine("167");
                    Console.WriteLine("178");
                    Console.WriteLine("189");
                    Console.WriteLine("190");
                    Console.WriteLine("191");
                    Console.WriteLine("192");
                    Console.WriteLine("193");
                    Console.WriteLine("194");
                    int ISBN = Convert.ToInt32(Console.ReadLine());
                    Book BInfo = new Book();
                    BInfo.GetBook(ISBN);


                    break;
                case 5:
                    Console.WriteLine("Enter 5 again");
                    int ISBN1 = Convert.ToInt32(Console.ReadLine());
                    Book BInfo1 = new Book();
                    BInfo1.GetBook(ISBN1);
                    Console.ReadLine();




                    break;
            }   
            
        }
    }
}
