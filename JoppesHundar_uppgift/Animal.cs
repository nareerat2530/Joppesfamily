using System;

namespace JoppesHundar_uppgift
{
    public abstract class Animal
    {
        // constructor 
        protected Animal(int age, string name, string favFood, string breed, bool hungry)
        {
            Age = age;
            Name = name;
            FavFood = favFood;
            Breed = breed;
            Hungry = hungry;
        }

        protected int Age { get; set; }
        protected string Name { get; set; }
        protected string FavFood { get; set; }
        protected string Breed { get; set; }
        protected bool Hungry { get; set; }

        // this method implement Play method in Pet owner class 
        public Ball Interact(Ball ball)
        {
            if (Name.ToLower() == "leo")
            {
                ball.LowerQuality(2);
                return ball;
            }

            ball.LowerQuality(1);
            return ball;
        }

        public Mouse Interact(Mouse mouse)
        {
            if (Name.ToLower() == "haru")
            {
                mouse.LowerBatery(1);
            }
            return mouse;
        }
        // this method implement Feed method in Pet owner class 
        public string Eat(string food)
        {
            if (Name != "Haru")
            {
                return food == FavFood ? $"{Name} is eating {FavFood}.Sooooo yummy!" : $"{Name} does not want your food.Please give {Name} {FavFood}";
            }

            if (food != FavFood)
            {
                
                return Hungry_animal();
                
            }

            Hungry = false;
            return $"{Name} is eating {FavFood}. Sooo yummy!";
            
        }
        //this method will be called when user choose to feed the cat
        public string Hungry_animal()
        {
            var rnd = new Random();
            rnd.Next(2);
            if (rnd.Next(2) == 1)
            {
                Hungry = false;
                return $"{Name} is angry because you did not feed her {FavFood} \n {Name} goes to hunt a mouse instead \n {Name} found a mouse oooooh so yummyy";
                
            }
           
            
            return $"{Name} is angry because you did not feed her {FavFood} \n {Name} goes to hunt a mouse instead \n {Name} did not found a mouse. {Name} is still hungry";
            
        }

        public override string ToString()
        {
            return null;
        }
    }
}