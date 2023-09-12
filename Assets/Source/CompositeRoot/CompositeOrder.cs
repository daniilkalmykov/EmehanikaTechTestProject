using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class CompositeOrder : MonoBehaviour
    {
        [SerializeField] private PlayerCompositeRoot _playerCompositeRoot;
        [SerializeField] private TorchCompositeRoot _torchCompositeRoot;
        [SerializeField] private LevelCompositeRoot _levelCompositeRoot;
        [SerializeField] private CameraCompositeRoot _cameraCompositeRoot;
        [SerializeField] private GroundCompositeRoot _groundCompositeRoot;
        
        private void Awake()
        {
            _playerCompositeRoot.Compose();
            _torchCompositeRoot.Compose();
            _cameraCompositeRoot.Compose();
            _groundCompositeRoot.Compose();
            
            _levelCompositeRoot.Init(_torchCompositeRoot.Torch);
            _levelCompositeRoot.Compose();
        }
    }
}