using System.Collections;
using System.Collections.Generic;
using FlappyBull.Enums;
using UnityEngine;

namespace FlappyBull.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PrefabMovement : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 5f;
        [SerializeField] DirectionEnum direction;
        Rigidbody2D _rigidbody2D;


        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void OnEnable()
        {
            Vector2 directionObject = Vector2.left;
            if (direction == DirectionEnum.Right) directionObject = Vector2.right;

            _rigidbody2D.velocity = directionObject * moveSpeed;
        }
    }
}

