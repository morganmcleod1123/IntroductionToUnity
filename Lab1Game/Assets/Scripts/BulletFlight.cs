using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFlight : MonoBehaviour
{
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.AddForce(transform.up * 600);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
