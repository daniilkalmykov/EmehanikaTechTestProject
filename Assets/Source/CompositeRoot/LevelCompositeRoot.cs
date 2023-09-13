using System;
using Source.LevelSystem;
using Source.Models;
using Source.TimersSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Source.CompositeRoot
{
    public sealed class LevelCompositeRoot : CompositeRoot
    {
        [SerializeField] private Image _endScreen;
        [SerializeField] private ScoreCompositeRoot _scoreCompositeRoot;
        
        private Level _level;
        private ITorch _torch;
        private ITimer _timer;

        private void OnDisable()
        {
            _level.Ended -= OnEnded;
        }

        private void Update()
        {
            _level?.Update();
        }

        public override void Compose()
        {
            _endScreen.gameObject.SetActive(false);
            
            _level = new Level(_torch);

            _level.Ended += OnEnded;
        }

        public void Init(ITorch torch, ITimer timer)
        {
            _torch = torch ?? throw new ArgumentNullException();
            _timer = timer ?? throw new ArgumentNullException();
        }

        private void OnEnded()
        {
            PlayerData.PlayerData.SetTime(_timer.Time);
            
            _endScreen.gameObject.SetActive(true);
            _scoreCompositeRoot.Show();
            
            Time.timeScale = 0;
        }
    }
}