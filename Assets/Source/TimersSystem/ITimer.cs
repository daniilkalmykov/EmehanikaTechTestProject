namespace Source.TimersSystem
{
    public interface ITimer
    {
        float Time { get; }

        void Update(float deltaTime);
    }
}