using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float velY = 5f;
    float velX = 0f;

    public static Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(velX, velY); 
    }

    public static void Stick()
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            SceneManager.LoadScene(0);
        }
    }
}
