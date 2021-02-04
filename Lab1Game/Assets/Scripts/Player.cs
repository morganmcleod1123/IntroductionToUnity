using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(pos.x, transform.position.y);
        Firebullet();
    }

    void Firebullet()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        bullet.transform.position = new Vector2(pos.x, transform.position.y);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet);
        }
    }
}
