using Source.ButtonsSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(GameButton))]
    internal sealed class StartButtonCompositeRoot : CompositeRoot
    {
        [SerializeField] private Image _background;
        
        private GameButton _button;
        
        public override void Compose()
        {
            _button = GetComponent<GameButton>();
            _button.Init();
            
            _button.Clicked += OnClicked;            
        }

        private void OnClicked()
        {
            _background.gameObject.SetActive(false);
            
            Time.timeScale = 1;
        }
    }
}