using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    static int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        tmp.text = score.ToString();
    }

    private void Update()
    {
        tmp.text = score.ToString();
    }

    public static void scoreIncrement()
    {
        score++;
    }
}
