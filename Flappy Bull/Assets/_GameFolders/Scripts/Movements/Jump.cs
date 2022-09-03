using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBull.Movements
{
    public class Jump : MonoBehaviour
    {
        [SerializeField] private float jumpForce = 350f;

        public void JumpAction(Rigidbody2D rigidbody2D)
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(Vector2.up * jumpForce);//Physics need to be called in FixedUpdate, because it is intgreated with game engine physics logic. Default time 0.2

        }

    }

}
