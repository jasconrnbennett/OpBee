using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeController : MonoBehaviour
{

    private Rigidbody2D rb2D;
    public float force = 100;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.isKinematic = true;
    }

    private void OnMouseUp()
    {
        rb2D.isKinematic = false;
        rb2D.AddForce(transform.right * force);
    }

    private void SlowBee()
    {
        Debug.Log("SlowBee");
        rb2D.velocity = rb2D.velocity * 0.85f;
    }

    private void FastBee()
    {
        Debug.Log("FastBee");
        rb2D.velocity = rb2D.velocity * 1.15f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bee Trigger Tag = " + collision.tag);
        if (collision.tag == "Smoke")
        {
            SlowBee();
        }

        if(collision.tag == "Fan")
        {
            FastBee();
        }
    }
}
