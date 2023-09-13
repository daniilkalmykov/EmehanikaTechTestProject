using System;
using UnityEngine;
using UnityEngine.UI;

namespace Source.ButtonsSystem
{
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