using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBird : MonoBehaviour
{
    public GameObject bird;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("DropBird", 2f, 2.5f);
        StartCoroutine("DropBird2");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DropBird()
    {
        Instantiate(bird);
    }

    IEnumerator DropBird2()
    {
        yield return new WaitForSeconds(2f);
        for (; ; )
        {
            Instantiate(bird);
            yield return new WaitForSeconds(2.5f);
        }
    }
   
}
