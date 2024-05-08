namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Chevy";
            myCar.Model = "Silverado";
            myCar.Year = 2021;

            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2016
            };
            var carList = new List<Car>(){myCar, mazda};
            Console.WriteLine(carList.Capacity);

        }

        
    }
}
