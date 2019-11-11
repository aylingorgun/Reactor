using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
