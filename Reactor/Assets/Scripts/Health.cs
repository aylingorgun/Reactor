using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text text;
    int lives;
 
    void Start()
    {
        lives = Random.Range(0,10);
        text.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = lives.ToString();

        createNewOne();
    }

    void createNewOne()
    {
        if(lives <= 0)
        {
            //Destroy(gameObject);
            lives = Random.Range(0, 10);
            text.text = lives.ToString();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            // Destroy(collision.gameObject);
            Bullet.Stick();
            collision.gameObject.transform.parent = this.gameObject.transform;
            lives -= Gun.damage;
            Score.scoreIncrement();
        }
    }
}
