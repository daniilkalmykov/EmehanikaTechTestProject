using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class CompositeOrder : MonoBehaviour
    {
        [SerializeField] private PlayerCompositeRoot _playerCompositeRoot;
        
        private void Awake()
        {
            _playerCompositeRoot.Compose();
        }
    }
}