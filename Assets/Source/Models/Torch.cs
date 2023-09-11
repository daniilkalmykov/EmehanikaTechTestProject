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

        public void Update(float deltaTime)
        {
            TimeToFizzle -= deltaTime;
        }
    }
}