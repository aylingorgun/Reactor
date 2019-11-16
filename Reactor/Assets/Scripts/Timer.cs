using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public static float timeLeft = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 60.0f;
        tmp.text = timeLeft.ToString("f0");

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        tmp.text = timeLeft.ToString("f0");
        
        if (timeLeft <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
