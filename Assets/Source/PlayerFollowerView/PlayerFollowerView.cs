using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: InternalsVisibleTo("Assembly-Csharp")]
[assembly: InternalsVisibleTo("Infrastructure")]
namespace Source.PlayerFollowerView
{
    internal sealed class PlayerFollowerView : MonoBehaviour
    {
        private Transform _player;

        private void Update()
        {
            if (_player == null)
                return;

            var currentTransform = transform;
            var position = currentTransform.position;
            
            position.x = _player.position.x;
            currentTransform.position = position;
        }

        public void Init(Transform player)
        {
            _player = player;
        }
    }
}