using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private float finalSpeed;
    private float x;
    private float time;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.deltaTime;
        MoveLeft();
        MoveRight();
    }

    /*private void FixedUpdate()
    {
        Jump();
    }*/

    public void MoveLeft()
    {
        finalSpeed = speed + finalSpeed;
        GameObject.Find("Player").transform.position = new Vector3(finalSpeed, 0);
    }

    public void MoveRight()
    {
        finalSpeed = -speed + finalSpeed;
        GameObject.Find("Player").transform.position = new Vector3(finalSpeed, 0);
    }

    /*public void Move()
    {
        if (Input.GetKeyDown("left"))
        {
            x = Input.GetAxis("Horizontal");


            transform.position += (Vector3)new Vector2(x * speed * time, 0);
        }
        else if (Input.GetKeyDown("right"))
        {
            x = Input.GetAxis("Horizontal");


            transform.position += (Vector3)new Vector2(x * speed * time, 0);
        }
    }*/

    public void Jump()
    {
        rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        /*if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }*/
    }
}
