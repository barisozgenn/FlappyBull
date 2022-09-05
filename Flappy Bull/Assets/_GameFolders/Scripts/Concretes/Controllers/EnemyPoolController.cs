using System.Collections;
using System.Collections.Generic;
using FlappyBull.Pools;
using UnityEngine;

namespace FlappyBull.Controllers
{
    public class EnemyPoolController : ObstacleController
    {
        public override void SetObstaclePool()
        {
            EnemyPool.Instance.Set(this);
        }
    }
}

