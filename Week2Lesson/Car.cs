namespace Week2Lesson
{
    public class Car
    {
        //private variables 
        private int Year;
        private string Make;
        private string Model;
        private int numberOfDoors;
        private double Price;
        private Color color;
        private Size size;

        //blank Constructor to use if you do not have all vars.
        public Car()
        {
        }

        //Main Constructor to set most vars.
        public Car(int Year, string Make, string Model,
            int numberOfDoors, double Price)
        {
            this.Year = Year;
            this.Make = Make;
            this.Model = Model;
            this.numberOfDoors = numberOfDoors;
            this.Price = Price;
        }
        
        //Master Constructor
        public Car(int Year, string Make, string Model,
            int numberOfDoors, double Price, Color color, Size size)
        {
            this.Year = Year;
            this.Make = Make;
            this.Model = Model;
            this.numberOfDoors = numberOfDoors;
            this.Price = Price;
            this.color = color;
            this.size = size;
        }
        
        //Small Constructor
        public Car(string Model,
            double Price, Color color, Size size)
        {
            this.Model = Model;
            this.Price = Price;
            this.color = color;
            this.size = size;
        }

        //Get methods to get a cars attribue
        public Size getSize()
        {
            return size;
        }
        public Color getColor()
        {
            return color;
        }
        public int getYear()
        {
            return Year;
        }
        public string getMake()
        {
            return Make;
        }
        public string getModel()
        {
            return Model;
        }
        public int getNumOfDoors()
        {
            return numberOfDoors;
        }
        public double getPrice()
        {
            return Price;
        }

        //Methods for class setters
        public void setColor(Color color)
        {
            this.color = color;
        }
        public void setSize(Size size)
        {
            this.size = size;
        }
        public void setYear(int Year)
        {
            this.Year = Year;
        }
        public void setMake(string Make)
        {
            this.Make = Make;
        }
        public void setModel(string Model)
        {
            this.Model = Model;
        }
        public void setNumOfDoors(int numberOfDoors)
        {
            this.numberOfDoors = numberOfDoors;
        }
        public void setPrice(double Price)
        {
            this.Price = Price;
        }

        //Easy to read string for each car
        public override string ToString()
        {
            return "Year: "+Year+"\nMake: "+Make+"\nModel: "+Model+
                   "\nNumber Of Doors: "+numberOfDoors+
                   "\nPrice: "+Price+"\nColor: "+color+
                   "\nSize: "+size;
        }
    }

    //enum for size so that it doesn't
    //become a string and can set weight to it at some point
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    //enum for colors to make color variables gui ready
    public enum Color
    {
        Red,
        LightBlue,
        Grey,
        Champaigne,
        Blue,
        Purple,
        Black,
        White
    }
    
}