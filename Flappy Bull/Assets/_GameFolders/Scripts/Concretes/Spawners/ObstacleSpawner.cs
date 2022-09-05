 using System.Collections;
using System.Collections.Generic;
using FlappyBull.Abstracts.Spawners;
using FlappyBull.Controllers;
using FlappyBull.Movements;
using FlappyBull.Pools;
using UnityEngine;

namespace FlappyBull.Spawners
{
    public class ObstacleSpawner : BaseSpawners
    {

        //[SerializeField] ObstacleController[] obstaclePrefabs;
        [SerializeField] Color[] obstaclePrefabColors;


        protected override void SpawnObject()
        {
            //int obstacleRandomIndex = Random.Range(0, obstaclePrefabs.Length);
            //var selectedObstacleObject = ObstacleCandleChangeSpriteColor(item:obstaclePrefabs[obstacleRandomIndex]);
            // selectedObstacleObject = ObstacleCandleChangeSize(item: selectedObstacleObject);

            // Instantiate(original: selectedObstacleObject, parent: this.transform);//used parent varaible because prefabs will be created as child object in spawner

            ObstacleController poolObstacle = ObstaclePool.Instance.Get();
            poolObstacle.transform.position = this.transform.position;
            poolObstacle = ObstacleCandleChangeSpriteColor(item: poolObstacle);
            poolObstacle = ObstacleCandleChangeSize(item: poolObstacle);

            poolObstacle.gameObject.SetActive(true);

        }

        private ObstacleController ObstacleCandleChangeSpriteColor(ObstacleController item)
        {
            item.transform.GetChild(0).GetComponent<SpriteRenderer>().color = obstaclePrefabColors[Random.Range(0, obstaclePrefabColors.Length)];
            return item;
        }
        private ObstacleController ObstacleCandleChangeSize(ObstacleController item)
        {
            item.transform.localScale = new Vector3(.5f, Random.Range(.5f, .9f), 1);
            return item;
        }
    }
}

