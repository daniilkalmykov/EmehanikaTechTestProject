using System;
using Source.Models;
using UnityEngine;

namespace Source.TorchView
{
    internal sealed class TorchView : MonoBehaviour
    {
        private ITorch _torch;
        private Light _light;
        
        private void Update()
        {
            if (_torch == null)
                return;

            _light.intensity = _torch.TimeToFizzle;
        }

        public void Init(ITorch torch, Light currentLight)
        {
            _torch = torch ?? throw new ArgumentNullException();
            _light = currentLight;
        }
    }
}