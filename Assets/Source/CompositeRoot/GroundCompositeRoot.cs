using UnityEngine;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(PlayerFollowerView.PlayerFollowerView))]
    internal sealed class GroundCompositeRoot : CompositeRoot
    {
        [SerializeField] private Transform _player;

        private PlayerFollowerView.PlayerFollowerView _playerFollowerView;
        
        public override void Compose()
        {
            _playerFollowerView = GetComponent<PlayerFollowerView.PlayerFollowerView>();
            
            _playerFollowerView.Init(_player);
        }
    }
}