using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBull.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void RestartGameButtonClick()
        {
            GameManager.Instance.RestartGame();
        }
        public void MenuGameButtonClick()
        {
            Debug.Log("Menu Button is clicked");
        }
    }

}
