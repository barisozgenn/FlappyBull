using System.Collections;
using System.Collections.Generic;
using FlappyBull.Abstracts.Spawners;
using FlappyBull.Controllers;
using FlappyBull.Pools;
using UnityEngine;
namespace FlappyBull.Spawners
{
    public class EnemySpawner : BaseSpawners
    {
        //[SerializeField] ObstacleController enemyPrefab;

        protected override void SpawnObject()
        {
            //will be calling by object pool//Instantiate(original: enemyPrefab, parent: this.transform);//used parent varaible because prefabs will be created as child object in spawner

            ObstacleController newEnemy = EnemyPool.Instance.Get();
            newEnemy.transform.position = this.transform.position;
            newEnemy.gameObject.SetActive(true);

        }
    }
}

