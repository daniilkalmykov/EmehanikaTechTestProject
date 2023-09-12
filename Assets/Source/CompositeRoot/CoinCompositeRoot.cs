using Source.Models;
using UnityEngine;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(Collider))]
    internal sealed class CoinCompositeRoot : CompositeRoot
    {
        [SerializeField] private float _bonusTime;
        
        private Coin _coin;
        private Collider _collider;

        public ICoin Coin => _coin;
        
        public override void Compose()
        {
            _coin = new Coin(_bonusTime);
            
            _collider = GetComponent<Collider>();
            _collider.isTrigger = true;
        }
    }
}