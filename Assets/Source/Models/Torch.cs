using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Assembly-Csharp")]
namespace Source.Models
{
    internal sealed class Torch : ITorch
    {
        public Torch(float timeToFizzle)
        {
            TimeToFizzle = timeToFizzle;
        }

        public float TimeToFizzle { get; private set; }
        
        public void TryAddTime(float time)
        {
            if (time <= 0)
                throw new ArgumentException();

            TimeToFizzle += time;
        }

        public void ReduceTime(float time)
        {
            if (time <= 0)
                throw new ArgumentException();

            TimeToFizzle -= time;
        }

        public void Update(float deltaTime)
        {
            TimeToFizzle -= deltaTime;
        }
    }
}