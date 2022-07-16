using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float speed = 100;

    public float DelayBetweenThrows = 0;
    float lastThrowDate;

    public static int damage = 1;

    private void Start()
    {
        lastThrowDate = Time.time;
    }

    private void FixedUpdate()
    {
        if ((Time.time - lastThrowDate > DelayBetweenThrows) && Input.GetMouseButton(0))
        {
            Fire();
            lastThrowDate = Time.time + DelayBetweenThrows;
        }
    }

    void Fire(){
        Rigidbody2D bulletInstance = Instantiate(bullet, transform.position, Quaternion.Euler(new Vector3(0, 0, 1))) as Rigidbody2D;
        bulletInstance.AddForce(transform.forward * speed);

        //bulletInstance.velocity = transform.forward * maxSpeed;
        // Physics2D.IgnoreCollision(bulletInstance.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }
}
