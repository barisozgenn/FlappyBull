using System.Collections;
using System.Collections.Generic;
using FlappyBull.Controllers;
using UnityEngine;

namespace FlappyBull.Combats
{
    public class InstantiateProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController[] projectilePrefabs;
        [SerializeField] Transform projectileSpawnerTransform;
        [SerializeField] GameObject projectileParent;
        [SerializeField] float delayProjectile = 0.7f;

        float _currentDelayTime = 0f;
        bool _canFire = false;

        private void Update()
        {
            _currentDelayTime += Time.deltaTime;
            if (_currentDelayTime > delayProjectile)
            {
                _canFire = true;
                _currentDelayTime = 0f;
            }
        }
        public void InstantiateFireAction()
        {
            if (_canFire)
            {
                ProjectileController projectileControllerPrefab = Instantiate(original: projectilePrefabs[Random.Range(0, projectilePrefabs.Length)], position: projectileSpawnerTransform.position, rotation: projectileSpawnerTransform.rotation);
                projectileControllerPrefab.transform.parent = projectileParent.transform;

                _canFire = false;
            }
        }
    }
}

