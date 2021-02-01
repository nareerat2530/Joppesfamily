namespace JoppesHundar_uppgift
{
    public class Puppy : Dog
    {
        public Puppy(int age, string name, string favFood, string breed, bool hungry) : base(age, name, favFood, breed,
            hungry)
        {
        }

        public override string ToString()
        {
            return
                $"My name is {Name}. I am {Age} month old. I am a {Breed} with a small cute tail and I love {FavFood}.";
        }
    }
}