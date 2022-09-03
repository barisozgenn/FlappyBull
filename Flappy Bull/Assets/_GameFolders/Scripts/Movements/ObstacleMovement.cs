using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBull.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class ObstacleMovement : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 5f;
        Rigidbody2D _rigidbody2D;


        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _rigidbody2D.velocity = Vector2.left * moveSpeed;
        }
    }
}

