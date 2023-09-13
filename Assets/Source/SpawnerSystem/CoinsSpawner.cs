using System;
using Source.CompositeRoot;

namespace Source.SpawnerSystem
{
    internal class CoinsSpawner : Spawner<CoinCompositeRoot>
    {
        protected override void InitObjects()
        {
            foreach (var root in GetObjects())
            {
                if (root.TryGetComponent(out CoinCompositeRoot coinCompositeRoot) == false)
                    throw new ArgumentNullException();

                coinCompositeRoot.Compose();
            }
        }
    }
}