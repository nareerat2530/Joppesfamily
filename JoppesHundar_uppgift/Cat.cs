namespace JoppesHundar_uppgift
{
    public class Cat : Animal
    {
        private int _age1;
        private string _name1;

        public Cat(int age, string name, string favFood, string breed, bool hungry) : base(age, name, favFood, breed,
            hungry)
        {
            _name1 = name;
            _age1 = age;
        }

        public override string ToString()
        {
            return
                $"My name is {Name}, I am {Age} years old and I am a {Breed} with big fur. My Favorite food is {FavFood}";
        }
    }
}