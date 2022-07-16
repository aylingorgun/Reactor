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
        lives = Random.Range(5,11);
        text.text = lives.ToString();
    }

    void Update()
    {
        text.text = lives.ToString();
        createNewOne();

    }

    void createNewOne()
    {
        if(lives <= 0)
        {
            lives = Random.Range(5, 11);
            text.text = lives.ToString();
            Score.scoreIncrement();
        }
    }

    List<GameObject> go = new List<GameObject>();
    void OnCollisionEnter2D(Collision2D collision)
    {    
        if ((collision.gameObject.tag == "Bullet") && collision != null)
        {
            go.Add(collision.gameObject);

            Bullet.Stick();
            collision.gameObject.transform.parent = this.gameObject.transform;
            lives -= Gun.damage;
            
            if(lives <= 0)
            {
                foreach (GameObject i in go)
                {

                    Destroy(i);
                }
            }
        }
    }
}
