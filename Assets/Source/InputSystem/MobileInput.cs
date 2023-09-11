using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: InternalsVisibleTo("Assembly-Csharp")]
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