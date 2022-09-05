using System.Collections;
using System.Collections.Generic;
using FlappyBull.Abstracts.Controllers;
using FlappyBull.Pools;
using UnityEngine;

namespace FlappyBull.Controllers
{
    public abstract class ObstacleController : PrefabLifeCycleController
    {
        public override void KillGameObject()
        {
            _currentTime = 0f;
            // ObstaclePool.Instance.Set(poolObject: this);
            SetObstaclePool();
        }

        public abstract void SetObstaclePool();
    }

}
