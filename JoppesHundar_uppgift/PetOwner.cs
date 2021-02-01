using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace JoppesHundar_uppgift
{
    public class PetOwner
    {
        private const int MaxInt = 3;
        private const int MinInt = 0;

        //Constructor
        public PetOwner(int age, List<Animal> pets)
        {
            Age = age;
            Pets = pets;
            Ball = new Ball("red", 10);
            Mouse = new Mouse("grey", 10);
        }
        //property
        private int Age { get; }
        private List<Animal> Pets { get; }
        private Ball Ball { get; set; }
        private Mouse Mouse { get; set; }

        public string Play(string name)
        {
           
            if (name != null)
                switch (name.ToLower())
                {
                    case "haru":
                    {
                        Mouse = Pets[0].Interact(Mouse);
                        
                        return ($"{name} run after mouse. Sooo fun for Haru ");
                    }
                        
                    case "leo":
                    {
                        Ball = Pets[1].Interact(Ball);
                        
                        return ($"{name} bites very hard and the ball looses some quality");
                    }
                        
                    case "poppy":
                    {
                        Pets[2].Interact(Ball);
                       
                        return ($"{name} bites so soft and the ball looses some small amount of quality");
                    }
                    default:
                        return ("You need to choose one of the pets");
                }
            return null;
        }

        public List<Animal> List_animals()
        {
            return Pets;
        }
        
        public string Feed(string name, string food)
        {
            switch (name.ToLower())
                {
                    case "haru":
                        return Pets[0].Eat(food);
                    case "leo":
                        return Pets[1].Eat(food);
                    case "poppy":
                        return Pets[2].Eat(food);
                    default:
                        MainMenu();
                        return "";
                }
            
        }
        // check if the value of ball equal to 0 , so it needs to buy a new ball
        public string Check_ball()
        {
            var contains = Ball.ToString().Contains("0");
            if (contains)
            {
                return "You need to buy a new ball";
               
            }

            return (Ball.ToString());
        }

        public string Check_mouse()
        {
            var contains = Mouse.ToString().Contains("0");
            if (contains)
            {
                return "You need to buy a new mouse";
                
            }
            return Mouse.ToString();
        }

      
        public void MainMenu()
        {
            var userInput = "";
            do
            {
                Console.WriteLine("\n___________________________________________________");
                Console.WriteLine("\nWelcome to the Nammys animal family \n");
                Console.WriteLine("Press the number you would like");
                Console.WriteLine("Press 1  if you want to play with the cute animal");
                Console.WriteLine("Press 2  if you want to Feed the cute animal");
                Console.WriteLine("Press 3  if you see a list of animal");
                Console.WriteLine("Press 0 if you would like to leave us");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1": 
                        for (var i = 0; i < Pets.Count; i++) Console.WriteLine(Pets[i]);
                        Console.WriteLine("Please write the name of animal that you would like to play with");
                        var choiceOfPet = Console.ReadLine().ToLower();
                        Console.WriteLine(Play(choiceOfPet));
                        if (choiceOfPet == "haru")
                        {
                            Console.WriteLine( Check_mouse());
                        }
                        else
                        {
                            Console.WriteLine(Check_ball());
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nlist of animal");
                        foreach (var pet in Pets) Console.WriteLine(pet);
                        Console.WriteLine();
                        Console.WriteLine("Please write the name of the animal from the list that you would like to feed");
                        var name = Console.ReadLine();
                        Console.WriteLine($"Please write the food you would like to feed to {name}");
                        var food = Console.ReadLine();
                        Console.WriteLine(Feed(name,food));
                        break;

                    case "3":
                        var pets = List_animals();
                        foreach (var pet in pets)
                        {
                            Console.WriteLine(pet);
                        }
                        break;
                    case "0":
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    default: 
                        Console.WriteLine($"Only number above {MinInt} and up to {MaxInt} are valid");
                        break;
                }
            } while (userInput != "0");

            Console.WriteLine();
            Console.WriteLine();
        }

        public override string ToString()
        {
            return null;
        }
    }
}