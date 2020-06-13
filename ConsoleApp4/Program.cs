using System;

namespace ConsoleApp4
{
    class TV
    {
        public int NowChannel;
        public char NextChannel;
        
        
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Для переключение след. канала нажмите '+'." +
                " Для переключения пред. канала нажмите '-'." +
                "Для перехода на определенный канал напишите его номер (1-100)");
            
            TV ch = new TV();
            ch.NowChannel = 1;
            Console.WriteLine("Вы на " + ch.NowChannel + " канале");
            try
            {
                do
                {
                    ch.NextChannel = char.Parse(Console.ReadLine());
                    
                    if (ch.NextChannel == '+')
                    {
                        ch.NowChannel += 1;
                        if (ch.NowChannel > 100)
                            ch.NowChannel = 1;
                        Console.WriteLine("Вы на " + ch.NowChannel + " канале");
                    }
                    else if (ch.NextChannel == '-')
                    {
                        ch.NowChannel -= 1;
                        if (ch.NowChannel < 1)
                            ch.NowChannel = 100;
                        Console.WriteLine("Вы на " + ch.NowChannel + " канале");
                    }
                    else throw new Exception();
                    ch.NowChannel = int.Parse(Console.ReadLine());
                    if (ch.NowChannel > 100 || ch.NowChannel < 1)
                    {
                        Console.WriteLine("Канал не существует");
                    }
                    else Console.WriteLine("Вы на " + ch.NowChannel + " канале");
                }
                while (true);
            }
            catch(Exception)
            {
                Console.WriteLine("Для переключение след. канала нажмите '+'." +
               " Для переключения пред. канала нажмите '-'." +
               "Для перехода на определенный канал напишите его номер (1-100)");
            }
            Console.ReadKey();

        }
    }
}
