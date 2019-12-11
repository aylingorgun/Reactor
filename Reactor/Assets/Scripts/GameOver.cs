using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject goPanel;
    public static bool gameOverTime;
    public static bool gameOverHit;

    public Text text;
    public Text best;

    private void Start()
    {
        goPanel.SetActive(false);
        gameOverTime = false;
        gameOverHit = false;
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (gameOverTime)
        {
            goPanel.SetActive(true);
            text.text = "Out of Time !";
            best.text = PlayerPrefs.GetInt("PersonalBest").ToString();
            Time.timeScale = 0;
        } else if (gameOverHit)
        {
            goPanel.SetActive(true);
            text.text = "Target error !";
            best.text = PlayerPrefs.GetInt("PersonalBest").ToString();
            Time.timeScale = 0;
        }
    }

    public void GameOverFinish()
    {
        SceneManager.LoadScene(0);
    }
}
