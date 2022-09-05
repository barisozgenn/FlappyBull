using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBull.UIs
{
    public class MenuCanvas : MonoBehaviour
    {
        public void StartButtonClick()
        {
            GameManager.Instance.StartGame();
        }
        public void ExitButtonClick()
        {
            GameManager.Instance.ExitGame();
        }
    }

}
