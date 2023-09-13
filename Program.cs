using System;

namespace GenericsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyData DataToUseInGeneric = new MyData();
            DataToUseInGeneric.Number1 = 1000;
            Generic1<MyData> GenericClassImplementationInstance = new Generic1<MyData>(DataToUseInGeneric);
            Generic1<MyData>.ShowNumber();

        }
    }
    interface IGeneric1
    {
        int Number1 { get; set; }
    }
    class MyData : IGeneric1
    {
        public int Number1 { get; set; }
    }
    class Generic1<T> where T : IGeneric1
    {
        public static T data;
       public Generic1(T N)
        {
            data = N;
        }

        public static void ShowNumber()
        {
            Console.WriteLine($"The number you sent to the class was:"+ data.Number1.ToString());
            Console.WriteLine("\n");
            Console.WriteLine($"Hola amigos como estan en este día.");
        }
    }
}
