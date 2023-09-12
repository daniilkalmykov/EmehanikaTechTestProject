namespace Source.Models
{
    internal sealed class Coin : ICoin
    {
        private readonly float _bonusTime;
        
        public Coin(float bonusTime)
        {
            _bonusTime = bonusTime;
        }
        
        public void Collect(ITorch torch)
        {
            torch.TryAddTime(_bonusTime);
        }
    }
}