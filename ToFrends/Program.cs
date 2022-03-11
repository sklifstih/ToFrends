using System;

namespace ToFrends
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface IUser
    {
        string Name { get; set; }
        string Adress { get; set; }
        string Login { get; set; }
        string Pass { get; set; }

    }

    interface IBio 
    {
        object City { get; set; }
        object Country { get; set; }
        string Request { get; set; }
        object Ideas { get; set; }

    }

    interface IChat
    {
        object Messang { get; set; }
        public object GetMessan();
        public void SendMessan();
        object Files { get; set; }
              
    }


}
