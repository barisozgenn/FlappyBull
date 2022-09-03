using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Don't add namespace to reach in every script
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        SingletonThisGameManager();

    }

    private void SingletonThisGameManager()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void RestartGame()
    {
        StartCoroutine(RestartGameScene());
    }
    private IEnumerator RestartGameScene()
    {
        yield return SceneManager.LoadSceneAsync("GameScene");
    }
}
