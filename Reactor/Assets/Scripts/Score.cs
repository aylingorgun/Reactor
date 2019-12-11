using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float highScore;
    public TextMeshProUGUI best;
    public TextMeshProUGUI tmp;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        highScore = (int)Timer.timeLeft * score;
        //best.text = PlayerPrefs.GetInt("PersonalBest").ToString();
        //highScore = Timer.timeLeft * score;
        if (!PlayerPrefs.HasKey("PersonalBest"))
        {
            //PlayerPrefs.GetInt("PersonalBest").ToString();
            PlayerPrefs.SetInt("PersonalBest", 0);
            PlayerPrefs.Save();
        }
        score = 0;
        tmp.text = score.ToString();
    }

    private void Update()
    {
        tmp.text = score.ToString();
        best.text = PlayerPrefs.GetInt("PersonalBest").ToString();
        highScore = (int)Timer.timeLeft * score;

        if (highScore > PlayerPrefs.GetInt("PersonalBest", (int)highScore))
        {
            PlayerPrefs.SetInt("PersonalBest", (int)highScore);
            best.text = PlayerPrefs.GetInt("PersonalBest", (int)highScore).ToString();
        }
     
    }

    public static void scoreIncrement()
    {
        score+=5;
    }
}
