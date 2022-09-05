using System.Collections;
using System.Collections.Generic;
using FlappyBull.Abstracts.Pools;
using FlappyBull.Controllers;
using UnityEngine;

namespace FlappyBull.Pools
{
    public class ObstaclePool : GenericPool<ObstaclePoolController>
    {
        public static ObstaclePool Instance { get; private set; }

        protected override void SingletonObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public override void ResetAllObjects()
        {
            foreach (var child in transform.GetComponentsInChildren<ObstaclePoolController>())
            {
                if (!child.gameObject.activeSelf)
                {
                    continue;
                }
                child.KillGameObject();
            }
        }
    }
}

