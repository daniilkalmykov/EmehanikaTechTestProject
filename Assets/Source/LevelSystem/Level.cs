using System;
using System.Runtime.CompilerServices;
using Source.Models;

[assembly: InternalsVisibleTo("Assembly-Csharp")]
namespace Source.LevelSystem
{
    internal sealed class Level
    {
        private readonly ITorch _torch;
        
        public Level(ITorch torch)
        {
            _torch = torch;
        }

        public event Action Ended;

        public void Update()
        {
            if (_torch.TimeToFizzle <= 0)
                Ended?.Invoke();
        }
    }
}