namespace JoppesHundar_uppgift
{
    public class Dog : Animal
    {
        private int _age;
        private string _name;

        //Constructor
        public Dog(int age, string name, string favFood, string breed, bool hungry) : base(age, name, favFood, breed,
            hungry)
        {
            _name = name;
            _age = age;
        }

        public override string ToString()
        {
            return $"My name is {Name}. I am {Age} years old and I am a {Breed}. My Favorite food is {FavFood}";
        }
    }
}