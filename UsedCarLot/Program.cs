using System;
using System.Collections.Generic;

namespace UsedCarLot
{
    class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public decimal Price;
        public double Mileage;

        public Car()
        {
        }
        public void CarList(List<Car> Inventory)
        {
            var thing = new System.Text.StringBuilder();
            Console.WriteLine("  #   Make         | Model           | Year |   Mileage  |   Price");
            Console.WriteLine("--------------------------------------------------------------------");
            for (int i = 0; i < Inventory.Count; i++)
            {
                thing.Append(String.Format("{0,6}", $" {i + 1})  ") + Inventory[i] + "\n");
            }
            Console.WriteLine(thing);
        }
        public virtual void SpecificCar()
        {
        }

    }
    class NewCar : Car
    {
        public override string ToString()
        {
            return String.Format("{0,-12} | {1,-15} | {2,-4} | {3,10} | {4,7}", Make, Model, Year, Mileage, Price);
        
        }
        public NewCar(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;

        }
    }
    class UsedCar : Car
    {
        public double Mileage;

        //public override string ToString()
        //{
        //    return $"\n   Make: {Make}\n   Model: {Model}\n   {Year}\n   {Price}\n   Mileage: {Mileage}";
        //}
        public override string ToString()
        {
         
            return String.Format("{0,-12} | {1,-15} | {2,-4} | {3,10} | {4,7}", Make, Model, Year, Mileage, Price);

        }
        public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
            this.Mileage = Mileage;
        }
    }
    class Program
    {
        static void SpecificCar(List<Car> Inventory, int index)
        {
            Console.WriteLine($"\n  Make:  {Inventory[index].Make}\n  Model:  {Inventory[index].Model}\n  Year:  {Inventory[index].Year}\n  Mileage:  {Inventory[index].Mileage}\n  Price:  {Inventory[index].Price}");
        }
        static void Main(string[] args)
        {
            Car Lot = new();

            List<Car> Inventory = new List<Car>();

            Inventory.Add(new NewCar("Honda", "Civic", 2021, 21250m));
            Inventory.Add(new NewCar("Honda", "Accord", 2021, 24970m));
            Inventory.Add(new NewCar("Honda", "CR-V", 2021, 25350m));
            Inventory.Add(new NewCar("Ford", "F-150", 2021, 29290m));
            Inventory.Add(new NewCar("Ford", "Mustang", 2021, 27205m));
            Inventory.Add(new NewCar("Ford", "Explorer", 2021, 32925m));
            Inventory.Add(new NewCar("Ferrari", "812 Superfast", 2021, 404494m));
            Inventory.Add(new NewCar("Ferrari", "SF90 Spider", 2021, 558000m));
            Inventory.Add(new NewCar("Ferrari", "F8 Tributo", 2021, 276550m));
            Inventory.Add(new NewCar("Tesla", "Model Y", 2021, 39990m));
            Inventory.Add(new NewCar("Tesla", "Model X", 2021, 79990m));
            Inventory.Add(new NewCar("Tesla", "Model 3", 2021, 44990m));

            Inventory.Add(new UsedCar("Tesla", "Model 3", 2019, 56990m, 10377));
            Inventory.Add(new UsedCar("Ford", "Mustang", 2016, 65990m, 15964));
            Inventory.Add(new UsedCar("Ford", "Escape", 2018, 19590m, 65074));
            Inventory.Add(new UsedCar("Nissan", "Versa", 2018, 14990m, 46205));
            Inventory.Add(new UsedCar("Volkswagen", "Jetta", 2014, 15990m, 67762));
            Inventory.Add(new UsedCar("Buick", "LaCrosse", 2010, 15590m, 98824));
            Inventory.Add(new UsedCar("Cadillac", "CTS", 2011, 44990m, 10377));
            Inventory.Add(new UsedCar("Hyundai", "Sonata", 2010, 14990m, 72448));
            bool keepgoingM = true;
            bool keepgoing1 = true;
            bool keepgoing2 = true;

            Console.WriteLine("Welcome to Al's Cars");
            do
            {
                Console.WriteLine("How can we help you today?");
                Console.WriteLine("'I'd like to...' Please choose an option: 1) Buy a car 2) Sell a car 3) Leave");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    do
                    {
                        Lot.CarList(Inventory);
                        Console.WriteLine("Please enter the number for the car you'd like to choose:");
                        int entry = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine(Inventory[entry]);
                        Console.WriteLine("Would you like to purchase this car? Y/N");
                        string response = Console.ReadLine().ToLower();

                        if (response == "y")
                        {
                            response = null;
                            Console.WriteLine("We hope you enjoy your new car!");
                            Inventory.RemoveAt(entry);
                        }
                        else if (response == "n") 
                        {
                            response = null;
                            Console.WriteLine("Would you like to choose a different car?");
                            response = Console.ReadLine().ToLower();
                            if (response == "n")
                            {
                                keepgoing1 = false;
                            }
                        }

                        Console.Clear();

                    } while (keepgoing1 == true);
                }
                else if (choice == 2)
                {
                    do
                    {
                        Console.WriteLine("Please enter the details of your car you'd like to sell:");
                        Console.WriteLine("Please enter the Year:");
                        Thread.Sleep(1000);
                        int rYear = int.Parse(Console.ReadLine());
                        Thread.Sleep (1000);
                        Console.WriteLine("Please enter the Make:");
                        Thread.Sleep(1000);
                        string rMake = Console.ReadLine();
                        Console.WriteLine("Please enter the Model:");
                        Thread.Sleep(1000);
                        string rModel = Console.ReadLine();
                        Console.WriteLine("Please enter the Mileage:");
                        Thread.Sleep(1000);
                        double rMileage = double.Parse(Console.ReadLine());
                        Thread.Sleep(1000);
                        Console.WriteLine("Please enter the Value:");
                        Thread.Sleep(1000);
                        decimal rPrice = decimal.Parse(Console.ReadLine());

                        Console.WriteLine($"You are interested in selling a {rYear} - {rMake} - {rModel} with {rMileage} miles, for ${rPrice}, correct? Y/N");
                        
                        string YCar = Console.ReadLine().ToLower();
                        if (YCar == "y")
                        {
                            Console.WriteLine("Thank you!");
                            Inventory.Add(new UsedCar(rMake, rModel, rYear, rPrice, rMileage));
                        }
                        
                            YCar = null;
                            Console.WriteLine("Would you like to sell a different car? Y/N");
                            YCar = Console.ReadLine().ToLower();
                            if (YCar == "n")
                            {
                                keepgoing2 = false;
                            }
                        

                        Console.Clear();


                    } while (keepgoing2 == true);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Okay have a nice day!");
                    keepgoingM = false;
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("I'm sorry, I don't understand; Please try again.");
                }

            } while (keepgoingM == true);

            



        }
    }


}
   