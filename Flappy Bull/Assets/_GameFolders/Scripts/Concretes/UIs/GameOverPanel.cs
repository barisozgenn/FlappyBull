using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBull.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void RestartGameButtonClick()
        {
            GameManager.Instance.StartGame();
        }
        public void MenuGameButtonClick()
        {
            GameManager.Instance.MenuGame();
        }
    }

}
