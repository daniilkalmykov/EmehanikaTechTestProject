using UnityEngine;

namespace Source.Infrastructure
{
    public sealed class Ground : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Material _material;
        
        private void Update()
        {
            if (_material == null)
            {
                return;
            }
            
            var materialMainTextureOffset = _material.mainTextureOffset;
            materialMainTextureOffset.x -= Time.deltaTime * _speed;

            _material.mainTextureOffset = materialMainTextureOffset;
        }
    }
}