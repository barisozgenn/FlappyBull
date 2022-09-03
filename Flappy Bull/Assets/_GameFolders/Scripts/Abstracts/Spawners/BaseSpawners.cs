using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBull.Abstracts.Spawners
{
    public abstract class BaseSpawners : MonoBehaviour
    {
        [Range(1f, 4.50f)]
        [SerializeField] float minSpawnTime = 1f;
        [Range(5f, 10f)]
        [SerializeField] float maxSpawnTime = 6f;

        float _currentLifeTime;
        float _limitLifeTime;

        private void Start()
        {
            ResetSpawnTime();
        }


        private void Update()
        {
            _currentLifeTime += Time.deltaTime;

            if (_currentLifeTime > _limitLifeTime)
            {
                SpawnObject();
                ResetSpawnTime();

            }
        }



        private void ResetSpawnTime()
        {
            _currentLifeTime = 0;
            _limitLifeTime = Random.Range(minSpawnTime, maxSpawnTime);
        }

        protected abstract void SpawnObject();
    }
}

