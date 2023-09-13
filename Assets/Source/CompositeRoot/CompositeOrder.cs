using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class CompositeOrder : MonoBehaviour
    {
        [SerializeField] private PlayerCompositeRoot _playerCompositeRoot;
        [SerializeField] private TorchCompositeRoot _torchCompositeRoot;
        [SerializeField] private LevelCompositeRoot _levelCompositeRoot;
        [SerializeField] private GroundCompositeRoot _groundCompositeRoot;
        [SerializeField] private TimerCompositeRoot _timerCompositeRoot;
        
        private void Awake()
        {
            Time.timeScale = 0;
            
            _playerCompositeRoot.Compose();
            _torchCompositeRoot.Compose();
            _groundCompositeRoot.Compose();
            _timerCompositeRoot.Compose();

            _levelCompositeRoot.Init(_torchCompositeRoot.Torch, _timerCompositeRoot.Timer);
            _levelCompositeRoot.Compose();
        }
    }
}