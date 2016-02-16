using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2

{
    class Program
    {
        static void Main(string[] args)
        {
            //create a register
            CD myCdasd = new CD();

            CD myCd = new CD();
            myCd.Artist = "Queen";
            myCd.CDName = "A Night at the Opera";

            Biisi biisi1 = new Biisi();
            biisi1.Songname = "Death on Two Legs";
            biisi1.Time = "3:43";

            Biisi biisi2 = new Biisi();
            biisi2.Songname = "Lazing on a Sunday Afternoon";
            biisi2.Time = "1:07";

            Biisi biisi3 = new Biisi();
            biisi3.Songname = "I'm in Love With My Car";
            biisi3.Time = "3:05";

            Biisi biisi4 = new Biisi();
            biisi4.Songname = "You're My Best Friend";
            biisi4.Time = "2:52";

            Biisi biisi5 = new Biisi();
            biisi5.Songname = "'39";
            biisi5.Time = "3:31";

            Biisi biisi6 = new Biisi();
            biisi6.Songname = "Sweet Lady";
            biisi6.Time = "4:03";

            Biisi biisi7 = new Biisi();
            biisi7.Songname = "Seaside Rendezvous";
            biisi7.Time = "2:15";

            Biisi biisi8 = new Biisi();
            biisi8.Songname = "The Prophet's Song";
            biisi8.Time = "8:21";

            Biisi biisi9 = new Biisi();
            biisi9.Songname = "Love of My Life";
            biisi9.Time = "3:39";

            Biisi biisi10 = new Biisi();
            biisi10.Songname = "Good Company";
            biisi10.Time = "3:23";

            Biisi biisi11 = new Biisi();
            biisi11.Songname = "Bohemian Rhapsody";
            biisi11.Time = "6:00";

            Biisi biisi12 = new Biisi();
            biisi12.Songname = "God Save the Queen";
            biisi12.Time = "1.18";

          
            // add songs to collection
            myCd.AddBiisi(biisi1);
            myCd.AddBiisi(biisi2);
            myCd.AddBiisi(biisi3);
            myCd.AddBiisi(biisi4);
            myCd.AddBiisi(biisi5);
            myCd.AddBiisi(biisi6);
            myCd.AddBiisi(biisi7);
            myCd.AddBiisi(biisi8);
            myCd.AddBiisi(biisi9);
            myCd.AddBiisi(biisi10);
            myCd.AddBiisi(biisi11);
            myCd.AddBiisi(biisi12);


            myCd.PrintData();
            Console.WriteLine();
        }
    }
}