using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 100;

    public static int damage = 1;

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire(){
        GameObject insBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
        Rigidbody insBulletRigid = insBullet.GetComponent<Rigidbody>();
        insBulletRigid.AddForce(Vector3.forward * speed);
    }
}
