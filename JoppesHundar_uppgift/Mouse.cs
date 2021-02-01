namespace JoppesHundar_uppgift
{
    public class Mouse
    {
        public Mouse(string color, int battery)
        {
            Color = color;
            Battery = battery;
        }

        private string Color { get; }
        private int Battery { get; set; }

        //this method will check on the quality of the ball.
        public void LowerBatery(int number)
        {
            Battery = Battery - number;
        }
        // return the value to string
        public override string ToString()
        {
            return $"The mouse is {Color} and the battery is {Battery} ";
        }
    }
}
