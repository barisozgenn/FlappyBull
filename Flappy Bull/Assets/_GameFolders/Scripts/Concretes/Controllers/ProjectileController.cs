using System.Collections;
using System.Collections.Generic;
using FlappyBull.Abstracts.Controllers;
using UnityEngine;

namespace FlappyBull.Controllers
{
    public class ProjectileController : PrefabLifeCycleController
    {
        
        private void OnTriggerEnter2D(Collider2D collider)
        {
            Debug.Log("projectile hit => " + collider.gameObject.name);
            ObstacleController enemy = collider.GetComponent<ObstacleController>();
            //if (collider.gameObject.tag == "Enemy")
            if(enemy!=null)
            {
                GameManager.Instance.IncreaseGameScore();
                //Destroy(enemy.gameObject);
                enemy.KillGameObject();
            }
            //Destroy(this.gameObject);
            KillGameObject();
        }

        public override void KillGameObject()
        {
            Destroy(this.gameObject);
        }

    }

}
