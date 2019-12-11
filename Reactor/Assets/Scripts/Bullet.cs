using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float velY = 5f;
    float velX = 0f;
    
    public static Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Blink(2, 0.01f, .04f));
    }

    // Update is called once per frame
    void Update()
    {
        if(rb != null)
            rb.velocity = new Vector2(velX, velY); 
    }

    public static void Stick()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            GameOver.gameOverHit = true;
            //goPanel.SetActive(true);
            //SceneManager.LoadScene(0);
        }
    }

    IEnumerator Blink(int nTimes, float timeOn, float timeOff)
    {
        while (nTimes > 0)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            yield return new WaitForSeconds(timeOn);
            GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(timeOff);
            nTimes--;
        }


        GetComponent<Renderer>().enabled = true;

    }
}
