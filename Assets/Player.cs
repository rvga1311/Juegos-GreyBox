using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float movement;
    private Rigidbody2D Rigidbody2D;
    private bool isGrounded;

    public float speed = 5f;
    public float jumpForce = 3f;
    


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal movement
        movement  = Input.GetAxis("Horizontal");

        // Jump
        isGrounded = Physics2D.Raycast(transform.position, Vector3.down, 1.1f);

        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && isGrounded){
            Rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(movement  * speed, Rigidbody2D.velocity.y);
    }

    public void resetPosition()
    {
        transform.position = new Vector3(-9, -1, 0);
    }
}
