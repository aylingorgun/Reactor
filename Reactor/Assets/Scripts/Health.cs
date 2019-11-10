using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text text;
    int lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = 1;
        text.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = lives.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("dfs");
            //Destroy(collision.gameObject);
            lives--;
        }
    }
}
