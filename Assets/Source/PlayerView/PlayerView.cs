using System;
using System.Runtime.CompilerServices;
using Source.Infrastructure;
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
        private Rigidbody _rigidbody;
        private bool _onGround = true;

        private void Update()
        {
            if (_input == null || _movable == null || _rigidbody == null)
                return;

            Move();
            TryJump();
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.TryGetComponent(out Ground ground))
                _onGround = true;
        }

        private void OnCollisionExit(Collision other)
        {
            _onGround = false;
        }

        private void TryJump()
        {
            if (_input.Tapped == false || _onGround == false)
                return;

            var velocity = _rigidbody.velocity;

            velocity = new Vector3(velocity.x, _movable.JumpSpeed, velocity.z);
            _rigidbody.velocity = velocity;
        }

        private void Move()
        {
            var currentTransform = transform;
            currentTransform.position += Vector3.right * (_movable.Speed * Time.deltaTime);
        }

        public void Init(IMovable movable, IInput input, Rigidbody playerRigidbody)
        {
            _movable = movable ?? throw new ArgumentNullException();
            _input = input ?? throw new ArgumentNullException();
            _rigidbody = playerRigidbody;
        }
    }
}