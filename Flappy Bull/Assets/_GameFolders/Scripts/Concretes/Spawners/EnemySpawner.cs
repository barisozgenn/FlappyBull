using System.Collections;
using System.Collections.Generic;
using FlappyBull.Abstracts.Spawners;
using FlappyBull.Controllers;
using UnityEngine;
namespace FlappyBull.Spawners
{
    public class EnemySpawner : BaseSpawners
    {
        [SerializeField] ObstacleController enemyPrefab;

        protected override void SpawnObject()
        {
            Instantiate(original: enemyPrefab, parent: this.transform);//used parent varaible because prefabs will be created as child object in spawner
        }
    }
}

