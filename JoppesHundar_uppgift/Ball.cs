namespace JoppesHundar_uppgift
{
    public class Ball
    {
        public Ball(string color, int quality)
        {
            Color = color;
            Quality = quality;
        }

        private string Color { get; }
        private int Quality { get; set; }

        //this method will check on the quality of the ball.
        public void LowerQuality(int number)
        {
            Quality = Quality - number;
        }
        // return the value to string
        public override string ToString()
        {
            return $"The ball is {Color} and the quality is {Quality} ";
        }
    }
}