using System;
using Source.LevelSystem;
using Source.Models;
using UnityEngine;

namespace Source.CompositeRoot
{
    public sealed class LevelCompositeRoot : CompositeRoot
    {
        private Level _level;
        private ITorch _torch;

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
            _level = new Level(_torch);

            _level.Ended += OnEnded;
        }

        public void Init(ITorch torch)
        {
            _torch = torch ?? throw new ArgumentNullException();
        }

        private void OnEnded()
        {
            Time.timeScale = 0;
        }
    }
}