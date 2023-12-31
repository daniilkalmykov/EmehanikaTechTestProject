using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Assembly-Csharp")]
namespace Source.MovementSystem
{
    internal sealed class Movement : IMovable
    {
        public Movement(float speed, float jumpSpeed)
        {
            Speed = speed;
            JumpSpeed = jumpSpeed;
        }

        public float Speed { get; }
        public float JumpSpeed { get; }
    }
}