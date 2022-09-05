using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Don't add namespace to reach in every script
public class GameManager : MonoBehaviour
{
    [SerializeField] int gameScore;
    public static GameManager Instance { get; private set; }

    public event System.Action<int> OnScoreChange;
    public event System.Action OnNewSceneLoad;

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
    public void IncreaseGameScore()
    {
        gameScore++;
        OnScoreChange?.Invoke(gameScore);
    }

    public void StartGame()
    {
        gameScore = 0;
        Time.timeScale = 1;
        StartCoroutine(StartGameScene());
    }
    private IEnumerator StartGameScene()
    {
        OnNewSceneLoad?.Invoke();
        yield return SceneManager.LoadSceneAsync("GameScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void MenuGame()
    {
        gameScore = 0;
        Time.timeScale = 1;
        StartCoroutine(MenuGameScene());
    }
    private IEnumerator MenuGameScene()
    {
        OnNewSceneLoad?.Invoke();
        yield return SceneManager.LoadSceneAsync("MenuScene");
    }
}
