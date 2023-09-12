using UnityEngine;

namespace Source.Infrastructure
{
    internal sealed class SpawnerObject : MonoBehaviour
    {
        private void OnBecameInvisible()
        {
            gameObject.SetActive(false);
        }
    }
}