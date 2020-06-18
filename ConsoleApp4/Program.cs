using System;

namespace ConsoleApp4
{
    class TV
    {
        public int NowChannel;
    }

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Для переключение след. канала нажмите '+'." +
                " Для переключения пред. канала нажмите '-'.");

            TV ch = new TV();
            ch.NowChannel = 1;
            Console.WriteLine("Вы на " + ch.NowChannel + " канале");
                    while(true)
                    {
                        string sw = Console.ReadLine();
                        if(sw=="+")
                        {   
                         ch.NowChannel += 1;
                         if (ch.NowChannel > 100)
                         ch.NowChannel = 1;
                         Console.WriteLine("Вы на " + ch.NowChannel + " канале");
                         }
                         if (sw == "-")
                         {
                          ch.NowChannel -= 1;
                          if (ch.NowChannel < 1)
                          ch.NowChannel = 100;
                           Console.WriteLine("Вы на " + ch.NowChannel + " канале");
                         }
                         
                    }
                    
            

        }
    }
}        

        
    

