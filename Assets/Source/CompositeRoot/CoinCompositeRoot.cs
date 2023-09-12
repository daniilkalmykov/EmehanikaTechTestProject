using Source.Models;
using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class CoinCompositeRoot : CompositeRoot
    {
        [SerializeField] private float _bonusTime;
        
        private Coin _coin;

        public ICoin Coin => _coin;
        
        public override void Compose()
        {
            _coin = new Coin(_bonusTime);
        }
    }
}