using System;
using System.Runtime.CompilerServices;
using Source.InputSystem;
using Source.MovementSystem;
using UnityEngine;

[assembly: InternalsVisibleTo("Assembly-Csharp")]
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
            currentTransform.position += Vector3.right * (_movable.Speed * Time.deltaTime);
        }
        
        public void Init(IMovable movable, IInput input)
        {
            _movable = movable ?? throw new ArgumentNullException();
            _input = input ?? throw new ArgumentNullException();
        }
    }
}