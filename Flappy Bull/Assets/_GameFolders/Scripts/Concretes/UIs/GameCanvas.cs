using System;
using System.Collections;
using System.Collections.Generic;
using FlappyBull.Combats;
using UnityEngine;

namespace FlappyBull.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] private GameObject gameOverPanel;

        private void Awake()
        {
            gameOverPanel = transform.GetChild(1).gameObject;
        }
        private void Start()
        {
            DeadAction deadAction = FindObjectOfType<DeadAction>();//normally we need to cache in Awake method but at this time we will define another method after game lunch so here is ok
            deadAction.OnDead += HandleOnDead;
        }

        private void HandleOnDead()
        {
            gameOverPanel.SetActive(true);
        }
    }
}

