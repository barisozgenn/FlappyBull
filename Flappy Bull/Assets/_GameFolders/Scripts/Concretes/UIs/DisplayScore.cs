using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace FlappyBull.UIs
{
    public class DisplayScore : MonoBehaviour
    {
        TextMeshProUGUI _scoreText;
        void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            GameManager.Instance.OnScoreChange += HandleOnScoreChange;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnScoreChange -= HandleOnScoreChange;

        }
        private void HandleOnScoreChange(int score = 0)
        {
            _scoreText.text = score.ToString();
        }
    }

}
