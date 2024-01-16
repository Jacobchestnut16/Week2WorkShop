using System;

namespace Week2Lesson
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Car myFirstCar = new Car();
            //define size small compact car
            //medium suv
            //large truck
            myFirstCar = new Car(2024, "myCarMake", "e219",
                4, 42999.99, Color.White, Size.Medium);
            Console.WriteLine(myFirstCar.ToString());
        }
    }
}