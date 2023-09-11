using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class CompositeOrder : MonoBehaviour
    {
        [SerializeField] private PlayerCompositeRoot _playerCompositeRoot;
        [SerializeField] private TorchCompositeRoot _torchCompositeRoot;
        
        private void Awake()
        {
            _playerCompositeRoot.Compose();
            _torchCompositeRoot.Compose();
        }
    }
}