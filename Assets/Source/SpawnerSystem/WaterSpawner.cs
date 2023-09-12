using System;
using Source.CompositeRoot;
using UnityEngine;

namespace Source.SpawnerSystem
{
    internal sealed class WaterSpawner : Spawner<MonoBehaviour>
    {
        protected override void InitObjects()
        {
            foreach (var root in GetObjects())
            {
                if (root.TryGetComponent(out WaterCompositeRoot waterCompositeRoot) == false)
                    throw new ArgumentNullException();
                
                waterCompositeRoot.Compose();
            }
        }
    }
}