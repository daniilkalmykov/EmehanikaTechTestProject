using Source.TimersSystem;
using TMPro;
using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class TimerCompositeRoot : CompositeRoot
    {
        private TMP_Text _tmpText;
        private Timer _timer;

        public ITimer Timer => _timer;
        
        public override void Compose()
        {
            _tmpText = GetComponent<TMP_Text>();

            _timer = new Timer();
        }

        private void Update()
        {
            _timer?.Update(Time.deltaTime);
            
            _tmpText.text = _timer!.Seconds.ToString().Length == 1
                ? $"{_timer.Minutes} : 0{_timer.Seconds}"
                : $"{_timer.Minutes} : {_timer.Seconds}";
        }
    }
}