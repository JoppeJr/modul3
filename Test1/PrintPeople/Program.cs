using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPeople
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Persons("Odd Eirik", "28", "Tønsberg");
            var person2 = new Persons("Dani","26","Tønsberg");
            var person3 = new Persons("Thomas","38","Kvelde");
            var person4 = new Persons("Erik William","26","Holmestrand");


            person.ShowPersonInfo();
            person2.ShowPersonInfo();
            person3.ShowPersonInfo();
            person4.ShowPersonInfo();



            Console.ReadLine();

        }

        

       
    }
}
