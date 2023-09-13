using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[assembly: InternalsVisibleTo("Assembly-Csharp")]
namespace Source.ButtonsSystem
{
    [RequireComponent(typeof(Button))]
    internal sealed class GameButton : MonoBehaviour
    {
        private Button _button;

        public event Action Clicked;

        private void OnDisable()
        {
            _button.onClick.RemoveListener(() => Clicked?.Invoke());
        }

        public void Init()
        {
            _button = GetComponent<Button>();
            
            _button.onClick.AddListener(() => Clicked?.Invoke());
        }
    }
}