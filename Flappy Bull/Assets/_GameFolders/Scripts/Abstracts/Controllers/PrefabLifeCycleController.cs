using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBull.Abstracts.Controllers
{
    public abstract class PrefabLifeCycleController : MonoBehaviour
    {
        [SerializeField] float maxLifeTime = 5f;

        protected float _currentTime;

        private void Update()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime >= maxLifeTime)
            {
                //Destroy(this.gameObject);
                KillGameObject();
            }
        }

        public abstract void KillGameObject();
    }

}
