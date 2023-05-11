using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeShoot : MonoBehaviour
{
    public Rigidbody2D rb;
    public float power;
    public bool isPresent;

    public void Start()
    {
        rb.isKinematic = false;
        isPresent = true;
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            rb.AddForce(transform.up * power);
        }

    }

}
