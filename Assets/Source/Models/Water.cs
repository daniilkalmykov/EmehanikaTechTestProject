namespace Source.Models
{
    internal sealed class Water : IWater
    {
        private readonly float _timeToSpend;

        public Water(float timeToSpend)
        {
            _timeToSpend = timeToSpend;
        }

        public void Use(ITorch torch)
        {
            torch.ReduceTime(_timeToSpend);
        }
    }
}