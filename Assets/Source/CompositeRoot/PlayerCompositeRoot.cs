using Source.InputSystem;
using Source.MovementSystem;
using UnityEngine;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(MobileInput))]
    [RequireComponent(typeof(PlayerView.PlayerView))]
    internal sealed class PlayerCompositeRoot : CompositeRoot
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _jumpSpeed;
        [SerializeField] private TorchCompositeRoot _torchCompositeRoot;
        
        private PlayerView.PlayerView _playerView;
        private MobileInput _mobileInput;
        private Movement _movement;
        private Rigidbody _rigidbody;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out CoinCompositeRoot coinCompositeRoot) == false) 
                return;
            
            coinCompositeRoot.Coin.Collect(_torchCompositeRoot.Torch);
            Destroy(coinCompositeRoot);
        }

        public override void Compose()
        {
            _playerView = GetComponent<PlayerView.PlayerView>();
            _mobileInput = GetComponent<MobileInput>();
            _rigidbody = GetComponent<Rigidbody>();

            _movement = new Movement(_speed, _jumpSpeed);

            _playerView.Init(_movement, _mobileInput, _rigidbody);
        }
    }
}