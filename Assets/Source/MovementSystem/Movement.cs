namespace Source.MovementSystem
{
    internal sealed class Movement : IMovement
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