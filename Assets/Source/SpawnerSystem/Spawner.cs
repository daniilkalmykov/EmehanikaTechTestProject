using UnityEngine;

namespace Source.SpawnerSystem
{
    internal abstract class Spawner<T> : Pool<T> where T : MonoBehaviour
    {
        [SerializeField] private T[] _prefabs;
        [SerializeField] private float _delay;
        [SerializeField] private int _count;
        [SerializeField] private SpawnPoint[] _spawnPoints;

        private float _timeAfterLastSpawned;
            
        private void Awake()
        {
            for (var i = 0; i < _count; i++)
                CreateObject(_prefabs[Random.Range(0, _prefabs.Length)], transform.position);
            
            InitObjects();
        }

        private void Update()
        {
            _timeAfterLastSpawned += Time.deltaTime;
            
            if (TryGetObject(out var o) == false)
                return;

            if (_timeAfterLastSpawned < _delay)
                return;
            
            _timeAfterLastSpawned = 0;    
            SetObjects(o);
        }

        private void SetObjects(T o)
        {
            o.transform.position = _spawnPoints[Random.Range(0, _spawnPoints.Length)].transform.position;
            o.transform.SetParent(null);
            o.gameObject.SetActive(true);
        }

        protected abstract void InitObjects();
    }
}