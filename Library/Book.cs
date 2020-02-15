using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        
        public static void BookInfo(int ISBN)
        {
            //make a list of books using a jagged array
            string[][] bookInfo = new string[30][];
            bookInfo[0] = new string[4] { "ISBN: 123, ", "Title: The Old Man and the Sea, ", "Pages: 47, ", "Author: Some Author"};
            bookInfo[1] = new string[4] { "ISBN: 234, ", "Title: Age Old Prophecies, ", "Pages: 147, ", "Author: Fakey Mcfake" };
            bookInfo[2] = new string[4] { "ISBN: 345, ", "Title: Mobile Dick,", "PAges: 700, ", "Author: Mr. Notreal"};
            bookInfo[3] = new string[4] { "ISBN: 456, ", "Title: Book number 4, ", "Pages: 47, ", "Author: Some Author" };
            bookInfo[4] = new string[4] { "ISBN: 567, ", "Title: How to Die Peacefully, ", "Pages: 147, ", "Author: Deth Defyer" };
            bookInfo[5] = new string[4] { "ISBN: 678, ", "Title: Hotel Lobbies: a Reference,", "PAges: 700, ", "Author: Flor Ida" };
            bookInfo[6] = new string[4] { "ISBN: 789, ", "Title: Babes in Bikinis, ", "Pages: 400,000, ", "Author: Sexy Ed" };
            bookInfo[7] = new string[4] { "ISBN: 890, ", "Title: Get #REKD; A Nerd's Tale, ", "Pages: 147, ", "Author: Fakey Mcfake" };
            bookInfo[8] = new string[4] { "ISBN: 901, ", "Title: The Basics, ", "PAges: 700, ", "Author: Mr. Notreal" };
            bookInfo[9] = new string[4] { "ISBN: 102, ", "Title: Gary's Gaming Guiide, ", "Pages: 47, ", "Author: Gary Grossman" };
            bookInfo[10] = new string[4] { "ISBN: 103, ", "Title: Intl Holdings: Where to put Them, ", "Pages: 147, ", "Author: Bill Bates" };
            bookInfo[11] = new string[4] { "ISBN: 104, ", "Title: A tale of two Tragedies, ", "PAges: 700, ", "Author: Real DaPress" };
            bookInfo[12] = new string[4] { "ISBN: 105, ", "Title: Basic Biology, ", "Pages: 47, ", "Author: Gen-iffer Etics" };
            bookInfo[13] = new string[4] { "ISBN: 106, ", "Title: Breaking Bad, ", "Pages: 147, ", "Author: M. Dealer" };
            bookInfo[14] = new string[4] { "ISBN: 107, ", "Title: Skating School Boundaries," , "PAges: 700, ", "Author: Mole Esther" };
            bookInfo[15] = new string[4] { "ISBN: 108, ", "Title: The Old and the Elderly, ", "Pages: 47, ", "Author: Mister No" };
            bookInfo[16] = new string[4] { "ISBN: 109, ", "Title: Pokemon and Where to Find Them, ", "Pages: 147, ", "Author: Miss Ingno" };
            bookInfo[17] = new string[4] { "ISBN: 110, ", "Title: Breathtakers, ", "PAges: 700, ", "Author: Craig Persons Rayburn" };
            bookInfo[18] = new string[4] { "ISBN: 111, ", "Title: The Ballet of the Bastards, ", "Pages: 47, ", "Author: J. Snow and R. Bolton" };
            bookInfo[19] = new string[4] { "ISBN: 112, ", "Title: Blondes of Bermuda, ", "Pages: 147, ", "Author: M. Sunk" };
            bookInfo[20] = new string[4] { "ISBN: 145, ", "Title: The Essence of the Dam, ", "PAges: 700, ", "Author: D. Waters" };
            bookInfo[21] = new string[4] { "ISBN: 156, ", "Title: Blatant Lies, ", "Pages: 47, ", "Author: T. Teller" };
            bookInfo[22] = new string[4] { "ISBN: 167, ", "Title: Blankety Blank, ", "Pages: 147, ", "Author: Unknown" };
            bookInfo[23] = new string[4] { "ISBN: 178, ", "Title: Matza Ball Recipes, ", "PAges: 700, ", "Author: J. Ish" };
            bookInfo[24] = new string[4] { "ISBN: 189, ", "Title: Blankey Statements, ", "Pages: 47, ", "Author: Lil' Baby" };
            bookInfo[25] = new string[4] { "ISBN: 190, ", "Title: Baby Names, ", "Pages: 147, ", "Author: N. Amer" };
            bookInfo[26] = new string[4] { "ISBN: 191, ", "Title: 'Murica's Finest, ", "PAges: 700, ", "Author: B. Eagle" };
            bookInfo[27] = new string[4] { "ISBN: 192, ", "Title: World's Greatest Dogs, ", "Pages: 47, ", "Author: B.Eagle" };
            bookInfo[28] = new string[4] { "ISBN: 193, ", "Title: Practical Magic, ", "Pages: 147, ", "Author: Saab Rina" };
            bookInfo[29] = new string[4] { "ISBN: 194, ", "Title: Google Eyes, ", "PAges: 700, ", "Author: S. Pie" };
            //list book by ISBN
            if (ISBN == 123)
            {

                Array.ForEach(bookInfo[0], Console.Write);
            }
            else if (ISBN == 234)
            {
                Array.ForEach(bookInfo[1], Console.Write);

            }
            else if (ISBN == 345)
            {
                Array.ForEach(bookInfo[2], Console.Write);
                
            }
            else if (ISBN == 456)
            {
                Array.ForEach(bookInfo[3], Console.Write);

            }
            else if (ISBN == 567)
            {
                Array.ForEach(bookInfo[4], Console.Write);

            }
            else if (ISBN == 678)
            {
                Array.ForEach(bookInfo[5], Console.Write);

            }
            else if (ISBN == 789)
            {
                Array.ForEach(bookInfo[6], Console.Write);

            }
            else if (ISBN == 890)
            {
                Array.ForEach(bookInfo[7], Console.Write);

            }
            else if (ISBN == 901)
            {
                Array.ForEach(bookInfo[8], Console.Write);

            }
            else if (ISBN == 102)
            {
                Array.ForEach(bookInfo[9], Console.Write);

            }
            else if (ISBN == 103)
            {
                Array.ForEach(bookInfo[10], Console.Write);

            }
            else if (ISBN == 104)
            {
                Array.ForEach(bookInfo[11], Console.Write);

            }
            else if (ISBN == 105)
            {
                Array.ForEach(bookInfo[12], Console.Write);

            }
            else if (ISBN == 106)
            {
                Array.ForEach(bookInfo[13], Console.Write);

            }
            else if (ISBN == 107)
            {
                Array.ForEach(bookInfo[14], Console.Write);

            }
            else if (ISBN == 108)
            {
                Array.ForEach(bookInfo[15], Console.Write);

            }
            else if (ISBN == 109)
            {
                Array.ForEach(bookInfo[16], Console.Write);

            }
            else if (ISBN == 110)
            {
                Array.ForEach(bookInfo[17], Console.Write);

            }
            else if (ISBN == 111)
            {
                Array.ForEach(bookInfo[18], Console.Write);

            }
            else if (ISBN == 112)
            {
                Array.ForEach(bookInfo[19], Console.Write);

            }
            else if (ISBN == 145)
            {
                Array.ForEach(bookInfo[20], Console.Write);

            }
            else if (ISBN == 156)
            {
                Array.ForEach(bookInfo[21], Console.Write);

            }
            else if (ISBN == 167)
            {
                Array.ForEach(bookInfo[22], Console.Write);

            }
            else if (ISBN == 178)
            {
                Array.ForEach(bookInfo[23], Console.Write);

            }
            else if (ISBN == 189)
            {
                Array.ForEach(bookInfo[24], Console.Write);

            }
            else if (ISBN == 190)
            {
                Array.ForEach(bookInfo[25], Console.Write);

            }
            else if (ISBN == 191)
            {
                Array.ForEach(bookInfo[26], Console.Write);

            }
            else if (ISBN == 192)
            {
                Array.ForEach(bookInfo[27], Console.Write);

            }
            else if (ISBN == 193)
            {
                Array.ForEach(bookInfo[28], Console.Write);

            }
            else if (ISBN == 194)
            {
                Array.ForEach(bookInfo[29], Console.Write);

            }
            else if (ISBN == 5)
            {
                Console.WriteLine(bookInfo.Count());
            }
            else if (ISBN == 0)
            {
                int DownTownCount = 0;
                int MapleCount = 0;
                for(int i=0; i<30; i++ )
                {
                   
                    
                    if(bookInfo[i][0].Contains("ISBN: 1"))
                    { 
                        
                        MapleCount++;

                    }
                    else
                    {
                        DownTownCount++;
                    }
                   
                }
                Console.WriteLine("Maplewood has " +MapleCount+ " books while the Downtown branch has "+ DownTownCount + " books.");
            }
            else
            {
                Console.WriteLine("Not a valid book");
            }
        }
        public void GetBook(int ISBN)
        {
            Book.BookInfo(ISBN);
            Console.ReadLine();
        }
    }
}
