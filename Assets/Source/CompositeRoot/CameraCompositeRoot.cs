using UnityEngine;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(CameraView.CameraView))]
    internal sealed class CameraCompositeRoot : CompositeRoot
    {
        [SerializeField] private Transform _player;

        private CameraView.CameraView _cameraView;

        public override void Compose()
        {
            _cameraView = GetComponent<CameraView.CameraView>();

            _cameraView.Init(_player);
        }
    }
}