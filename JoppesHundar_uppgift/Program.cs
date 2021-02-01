using System.Collections.Generic;

namespace JoppesHundar_uppgift
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pets = new List<Animal>();
            var Nammy = new PetOwner(33, pets);
            pets.Add(new Cat(2, "Haru", "fish", "Perser", false));
            pets.Add(new Dog(3, "Leo", "chicken", "Siberian husky", true));
            pets.Add(new Puppy(1, "Poppy", "banana", "Alaskan malamute", true));

            Nammy.MainMenu();
        }
    }
}