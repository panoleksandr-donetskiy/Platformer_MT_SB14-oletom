using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class platermove : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float move, movespeed;
    public int health;
    public Text hptext;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        hptext.text = health.ToString();
        if (health <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal") * movespeed;

        if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(move, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector2(move, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = new Vector2(0, 7);
        }
    }
}
