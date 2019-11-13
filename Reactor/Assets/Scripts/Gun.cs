using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 100;

    public float DelayBetweenThrows = .00001f;
    float lastThrowDate;

    public static int damage = 1;

    private void Start()
    {
        lastThrowDate = Time.time;
    }

    private void FixedUpdate()
    {
        if ((Time.time - lastThrowDate > DelayBetweenThrows) && Input.GetMouseButtonDown(0))
        {
            Fire();
            lastThrowDate = Time.time + DelayBetweenThrows;
        }
    }

    void Fire(){
        GameObject insBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
        Rigidbody insBulletRigid = insBullet.GetComponent<Rigidbody>();
        insBulletRigid.AddForce(Vector3.forward * speed);
    }
}
