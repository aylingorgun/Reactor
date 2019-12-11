using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeHit : MonoBehaviour
{
    public SpriteRenderer m_SpriteRenderer;

    private void Start()
    {
        m_SpriteRenderer.color = Color.yellow;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Bullet") && collision != null)
        {
            StartCoroutine("Colors");
            Destroy(collision.gameObject);
            Timer.timeLeft += 1f;
        }
    }

    IEnumerator Colors()
    {
        m_SpriteRenderer.color = Color.blue;
        yield return new WaitForSeconds(.5f);
        m_SpriteRenderer.color = Color.yellow;
    }
}
