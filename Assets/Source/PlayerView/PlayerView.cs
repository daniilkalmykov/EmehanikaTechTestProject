using System;
using Source.InputSystem;
using Source.MovementSystem;
using UnityEngine;

namespace Source.PlayerView
{
    internal sealed class PlayerView : MonoBehaviour
    {
        private IMovable _movable;
        private IInput _input;

        private void Update()
        {
            if (_input == null || _movable == null)
                return;

            var currentTransform = transform;
            currentTransform.position = currentTransform.right * (_movable.Speed * Time.deltaTime);
        }
        
        public void Init(IMovable movable, IInput input)
        {
            _movable = movable ?? throw new ArgumentNullException();
            _input = input ?? throw new ArgumentNullException();
        }
    }
}