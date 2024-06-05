using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //movement stuff
    public float speed;
    private Rigidbody2D rb2d;
    public float verticalInput;
    public float yRange;
    public float horizontalInput;
    public float xRange;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1.0f;
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.up * verticalInput * Time.deltaTime * speed);

        if (horizontalInput > 0)
        {
            transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed/2);
        }
        if (horizontalInput < 0)
        {
            transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed*1.25f);
        }

        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }
        if (transform.position.x > -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }
        if (transform.position.x < xRange)
        {
           transform.position = new Vector2(xRange, transform.position.y);
        }
    }
    
}