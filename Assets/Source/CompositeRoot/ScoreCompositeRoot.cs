using TMPro;
using UnityEngine;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(TMP_Text))]
    internal sealed class ScoreCompositeRoot : CompositeRoot
    {
        [SerializeField] private string _startText;
        
        private TMP_Text _tmpText;
        
        public override void Compose()
        {
            _tmpText = GetComponent<TMP_Text>();
        }

        public void Show()
        {
            _tmpText.text = $"{_startText} {(int)PlayerData.PlayerData.GetTime()} seconds";
        }
    }
}