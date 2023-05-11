using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeShooter : MonoBehaviour
{

    public Rigidbody2D rb;
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
        if (isPresent == false)
        {
            Instantiate(prefab, new Vector3(0.622699976f, -163.831604f, 0f), Quaternion.identity);
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
