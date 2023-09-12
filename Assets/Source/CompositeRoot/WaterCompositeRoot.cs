using Source.Models;
using UnityEngine;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(Collider))]
    internal sealed class WaterCompositeRoot : CompositeRoot
    {
        [SerializeField] private float _timeToReduce;

        private Water _water;
        private Collider _collider;

        public IWater Water => _water;

        public override void Compose()
        {
            _water = new Water(_timeToReduce);
            
            _collider = GetComponent<Collider>();
            _collider.isTrigger = true;
        }
    }
}