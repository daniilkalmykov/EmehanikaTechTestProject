using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Assembly-Csharp")]
namespace Source.TimersSystem
{
    internal sealed class Timer : ITimer
    {
        private const int SecondsInMinutes = 60;
        
        public float Time { get; private set; }
        public int Seconds { get; private set; }
        public int Minutes { get; private set; }
        
        public void Update(float deltaTime)
        {
            Time += deltaTime;
            
            Seconds = (int)Time - Minutes * SecondsInMinutes;
            Minutes = (int)Time / SecondsInMinutes;
        }
    }
}