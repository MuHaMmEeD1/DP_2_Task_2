
using DP_2_Task_2;

namespace Task2
{

    class Program
    {

        static void Main(string[] args)
        {

            List<Electrick> electricks = new List<Electrick>() { 
                
                new GunesEnerjisi(),
                new HuleyEnerjisi(),
                new AdaptrBuxarEnergisi()
            };


            foreach (Electrick i in electricks) { i.ElektirikiQaytar(); }



        }



    }

}


