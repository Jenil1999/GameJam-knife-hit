using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeShooter : MonoBehaviour
{

    public Rigidbody2D rb;
    public float power;
    public GameObject cardboard;
    public GameObject prefab;
    public bool isPresent;

    public void Start()
    {
        rb.isKinematic = false;
        isPresent = true;
    }

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            rb.AddForce(transform.up * power);
        }

        if (isPresent == false)
        {
            Instantiate(prefab, new Vector3(0.00999999978f, -3.47000003f, 0), Quaternion.identity);
            isPresent = true;
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("card"))
        {
            rb.isKinematic = true;

            rb.freezeRotation = true;
            rb.transform.parent = cardboard.transform;

            isPresent = false;

        }

    }
}
