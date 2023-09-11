using Source.Models;
using UnityEngine;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(Light))]
    [RequireComponent(typeof(TorchView.TorchView))]
    internal sealed class TorchCompositeRoot : CompositeRoot
    {
        [SerializeField] private float _timeToFizzle;
        
        private Torch _torch;
        private TorchView.TorchView _torchView;
        private Light _light;

        private void Update()
        {
            _torch?.Update(Time.deltaTime);
        }

        public override void Compose()
        {
            _torchView = GetComponent<TorchView.TorchView>();
            _light = GetComponent<Light>();
            
            _torch = new Torch(_timeToFizzle);

            _torchView.Init(_torch, _light);
        }
    }
}