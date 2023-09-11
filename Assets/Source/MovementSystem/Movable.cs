namespace Source.MovementSystem
{
    internal sealed class Movable : IMovable
    {
        public Movable(float speed, float jumpSpeed)
        {
            Speed = speed;
            JumpSpeed = jumpSpeed;
        }

        public float Speed { get; }
        public float JumpSpeed { get; }
    }
}