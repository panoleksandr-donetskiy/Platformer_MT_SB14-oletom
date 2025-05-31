using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platermove : MonoBehaviour
{
    public Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector3(-5, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector3(5, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = new Vector3(0, 5, 0);
        }
    }
}
