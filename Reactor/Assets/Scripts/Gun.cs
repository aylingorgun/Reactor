using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody2D bullet;
    public Transform FirePoint;

    // Start is called before the first frame update
    void Awake()
    {
        FirePoint = FirePoint.transform;
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire(){
        Instantiate(bullet, FirePoint.position, Quaternion.identity);
    }
}
