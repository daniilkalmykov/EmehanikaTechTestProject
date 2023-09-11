using Source.InputSystem;
using Source.MovementSystem;
using UnityEngine;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(MobileInput))]
    [RequireComponent(typeof(PlayerView.PlayerView))]
    internal sealed class PlayerCompositeRoot : CompositeRoot
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _jumpSpeed;
        
        private PlayerView.PlayerView _playerView;
        private MobileInput _mobileInput;
        private Movement _movement;

        public override void Compose()
        {
            _playerView = GetComponent<PlayerView.PlayerView>();
            _mobileInput = GetComponent<MobileInput>();

            _movement = new Movement(_speed, _jumpSpeed);

            _playerView.Init(_movement, _mobileInput);
        }
    }
}