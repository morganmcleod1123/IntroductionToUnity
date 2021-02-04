using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlightPath : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;
    private float direction;
    private float magnitude;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        direction = Random.Range(0.0f, 1.0f);
        magnitude = Random.Range(1.0f, 2.0f);
        if(direction < 0.5)
        {
            rigidbody2D.AddForce(transform.right * (-135 * magnitude));
        }
        else
        {
            rigidbody2D.AddForce(transform.right * (135 * magnitude));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -7)
        {
            Destroy(gameObject);
            GameManager.Instance.IncScore(-10);
        }
    }
}
