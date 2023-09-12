namespace Source.Models
{
    public interface ITorch
    {
        float TimeToFizzle { get; }

        void TryAddTime(float time);
        void ReduceTime(float time);
    }
}