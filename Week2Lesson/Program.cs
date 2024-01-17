using System;

namespace Week2Lesson
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            mainMenu();
        }

        public static void mainMenu()
        {
            int userInput = -1;
            String i = "";
            while (userInput == -1 || userInput > 5)
            {
                ConsoleColor ret = Console.BackgroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Welcome to Jacob's Dealership");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n \n \n[0]:List Cars" +
                                  "\n[1]:Select Car" +
                                  "\n[2]:Change Car" +
                                  "\n[3]:Create Car" +
                                  "\n[4]:Change Default Settings" +
                                  "\n[5]:Shutdown");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write("Option: ");
                try
                {
                    Console.BackgroundColor = ret;
                    i = Console.ReadLine();
                    userInput = int.Parse(i);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: "+i+", is not a valid option!");
                    throw;
                }
            }
            Console.WriteLine("i = "+i);
            switch (userInput)
            {
                /*                Console.WriteLine("[0]:List Cars" +
                                     "\n[1]:Select Car" +
                                     "\n[2]:Change Car" +
                                     "\n[3]:Create Car" +
                                     "\n[4]:Change Default Settings" +
                                     "\n[5]:Shutdown");*/
                case 0:
                    Console.WriteLine("List Cars");
                    listCars();
                    break;
                case 1:
                    Console.WriteLine("Select Car");
                    selectCar();
                    break;
                case 2:
                    Console.WriteLine("Change Car");
                    changeCar();
                    break;
                case 3:
                    Console.WriteLine("Create Car");
                    createCar();
                    break;
                case 4:
                    changeDefaultOptions();
                    Console.WriteLine("Change Default Options");
                    break;
                case 5:
                    Console.WriteLine("Shutdown");
                    shutdown();
                    break;
            }
        }

        private static int selectedCar = -1;
        public static void listCars()
        {
            if (carsIndex > 0)
            {
                for (int i = 0; i < carsIndex; i++)
                {
                    Console.WriteLine(i + ":\n" + cars[i].ToString() + "\n");
                }
            }
            mainMenu();
        }
        public static void selectCar()
        {
            Console.Write("Select car [0-"+(carsIndex-1)+"]: ");
            selectedCar = Int32.Parse(Console.ReadLine());
            Console.WriteLine(cars[selectedCar].ToString());
            mainMenu();
        }
        public static void changeCar()
        {
            int Year = 0;
            string Make = "";
            string Model = "";
            int numberOfDoors = 0;
            double Price = 0;
            Color color = Color.White;
            Size size = Size.Small;

            if (selectedCar != -1)
            {
                Console.WriteLine("Year: ");
                String val = Console.ReadLine();
                Year = Int32.Parse(val);
                Console.WriteLine("Make: ");
                Model = Console.ReadLine();
                Console.WriteLine("Model: ");
                Model = Console.ReadLine();
                Console.WriteLine("Number of Doors: ");
                val = Console.ReadLine();
                Year = Int32.Parse(val);
                Console.WriteLine("Price: ");
                val = Console.ReadLine();
                Year = Int32.Parse(val);
                Console.WriteLine("Color:(Red, LightBlue, Grey, Champaigne, Blue, Purple, Black, White): ");
                string ret = Console.ReadLine();
                switch (ret)
                {
                    case "R":
                        color = Color.Red;
                        break;
                    case "L":
                        color = Color.LightBlue;
                        break;
                    case "G":
                        color = Color.Grey;
                        break;
                    case "C":
                        color = Color.Champaigne;
                        break;
                    case "P":
                        color = Color.Purple;
                        break;
                    case "B":
                        color = Color.Blue;
                        break;
                    case "A":
                        color = Color.Black;
                        break;
                    case "W":
                        color = Color.White;
                        break;
                }

                Console.WriteLine("Size (Small, Medium, Large): ");
                ret = Console.ReadLine();
                switch (ret)
                {
                    case "S":
                        break;
                    case "M":
                        break;
                    case "L":
                        break;
                }

                cars[selectedCar] = new Car(Year, Make, Model, numberOfDoors, Price, color, size);
            }
            else
            {
                Console.WriteLine("Select a car first");
            }

            selectedCar = -1;

            mainMenu();
        }

        private static Car[] cars = new Car[9999];
        private static int carsIndex = 0;
        private static int defalt = 0;
        public static void createCar()
        {
            int Year = 0;
            string Make = "";
            string Model = "";
            int numberOfDoors = 0;
            double Price = 0;
            Color color = Color.White;
            Size size = Size.Small;
            
            if (defalt == 2)
            {
                Console.WriteLine("Make: ");
                Make = Console.ReadLine();
                Console.WriteLine("Model: ");
                Model = Console.ReadLine();
                Console.WriteLine("Color ([R]ed, [L]ightBlue, [G]rey, [C]hampaigne, [B]lue, [P]urple, Bl[A]ck, [W]hite): ");
                String ret = Console.ReadLine();
                switch (ret)
                {
                    case "R":
                        color = Color.Red;
                        break;
                    case "L":
                        color = Color.LightBlue;
                        break;
                    case "G":
                        color = Color.Grey;
                        break;
                    case "C":
                        color = Color.Champaigne;
                        break;
                    case "P":
                        color = Color.Purple;
                        break;
                    case "B":
                        color = Color.Blue;
                        break;
                    case "A":
                        color = Color.Black;
                        break;
                    case "W":
                        color = Color.White;
                        break;
                }
                Console.WriteLine("Size ([S]mall, [M]edium, [L]arge): ");
                ret = Console.ReadLine();
                switch (ret)
                {
                    case "S":
                        break;
                    case "M":
                        break;
                    case "L":
                        break;
                }
            }
            else if (defalt == 1)
            {
                Console.WriteLine("Year: ");
                string val = Console.ReadLine();
                Year = Int32.Parse(val);
                Console.WriteLine("Make: ");
                Make = Console.ReadLine();
                Console.WriteLine("Model: ");
                Model = Console.ReadLine();
                Console.WriteLine("Number of Doors: ");
                val = Console.ReadLine();
                numberOfDoors = Int32.Parse(val);
                Console.WriteLine("Price: ");
                val = Console.ReadLine();
                Price = Int32.Parse(val);
            }
            else
            {
                Console.WriteLine("Year: ");
                String val = Console.ReadLine();
                Year = Int32.Parse(val);
                Console.WriteLine("Make: ");
                Make = Console.ReadLine();
                Console.WriteLine("Model: ");
                Model = Console.ReadLine();
                Console.WriteLine("Number of Doors: ");
                val = Console.ReadLine();
                numberOfDoors = Int32.Parse(val);
                Console.WriteLine("Price: ");
                val = Console.ReadLine();
                Price = Int32.Parse(val);                
                Console.WriteLine("Color:(Red, LightBlue, Grey, Champaigne, Blue, Purple, Black, White): ");
                string ret = Console.ReadLine();
                switch (ret)
                {
                    case "R":
                        color = Color.Red;
                        break;
                    case "L":
                        color = Color.LightBlue;
                        break;
                    case "G":
                        color = Color.Grey;
                        break;
                    case "C":
                        color = Color.Champaigne;
                        break;
                    case "P":
                        color = Color.Purple;
                        break;
                    case "B":
                        color = Color.Blue;
                        break;
                    case "A":
                        color = Color.Black;
                        break;
                    case "W":
                        color = Color.White;
                        break;
                }
                Console.WriteLine("Size (Small, Medium, Large): ");
                ret = Console.ReadLine();
                switch (ret)
                {
                    case "S":
                        break;
                    case "M":
                        break;
                    case "L":
                        break;
                }
            }
            cars[carsIndex] = new Car(Year, Make, Model, numberOfDoors, Price, color, size);
            carsIndex++;
            mainMenu();
        }
        public static void changeDefaultOptions()
        {
            int defaultOptionInput = 0;
            Console.WriteLine("[0]: Year, Make, Model, # of doors, Price, Color, Size" +
                              "\n[1]: Year, Make, Model, # of doors, Price" +
                              "\n[2]: Make, Model, Color, Size");
            defaultOptionInput = Int32.Parse(Console.ReadLine());
            switch (defaultOptionInput)
            {
                case 0:
                    defalt = 0;
                    break;
                case 1:
                    defalt = 1;
                    break;
                case 2:
                    defalt = 2;
                    break;
            }
            mainMenu();
        }

        public static void shutdown()
        {
            
        }
    }
}