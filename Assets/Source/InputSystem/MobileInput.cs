using System.Linq;
using UnityEngine;

namespace Source.InputSystem
{
    internal class MobileInput : MonoBehaviour, IInput
    {
        public bool Tapped { get; private set; }

        private void Update()
        {
            if (Input.touchCount != 1)
            {
                Tapped = false;
                return;
            }

            if (Input.touches.Any(touch => touch.phase == TouchPhase.Began))
            {
                Tapped = true;
                return;
            }

            Tapped = false;
        }
    }
}