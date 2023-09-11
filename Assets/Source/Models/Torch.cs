namespace Source.Models
{
    internal sealed class Torch : ITorch
    {
        public Torch(float timeToFizzle)
        {
            TimeToFizzle = timeToFizzle;
        }

        public float TimeToFizzle { get; }
    }
}