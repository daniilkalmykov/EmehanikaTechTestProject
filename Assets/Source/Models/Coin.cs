namespace Source.Models
{
    internal sealed class Coin : ICoin
    {
        public Coin(float bonusTime)
        {
            BonusTime = bonusTime;
        }

        public float BonusTime { get; }
    }
}