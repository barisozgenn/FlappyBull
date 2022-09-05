using System.Collections;
using System.Collections.Generic;
using FlappyBull.Pools;
using UnityEngine;

namespace FlappyBull.Controllers
{
    public class ObstaclePoolController : ObstacleController
    {
        public override void SetObstaclePool()
        {
            ObstaclePool.Instance.Set(this);
        }
    }
}


