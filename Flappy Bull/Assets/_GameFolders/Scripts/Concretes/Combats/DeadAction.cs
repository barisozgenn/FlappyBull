using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FlappyBull.Combats
{
    public class DeadAction : MonoBehaviour
    {
        private bool _isDead;
        private float _timeSpeed = 0.5f;

        public bool IsDead => _isDead;

        public event System.Action OnDead;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                _isDead = true;
                OnDead?.Invoke();

                Time.timeScale = _timeSpeed;
                StartCoroutine(DeadTimeSpeedStop());

                Debug.Log("collision => " + collision.gameObject.name);
            }
                
        }

        private IEnumerator DeadTimeSpeedStop()
        {
            yield return new WaitForSeconds(2);
            Time.timeScale = 0;
        }
    }

}
