namespace Source.TimersSystem
{
    internal sealed class Timer : ITimer
    {
        public float Time { get; private set; }
        
        public void Update(float deltaTime)
        {
            Time += deltaTime;
        }
    }
}