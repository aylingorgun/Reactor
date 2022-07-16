using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutherCircle : MonoBehaviour
{

    public int degree = 18;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, degree * Time.deltaTime); //rotates 50 degrees per second around z axis
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
        }
    }
}
