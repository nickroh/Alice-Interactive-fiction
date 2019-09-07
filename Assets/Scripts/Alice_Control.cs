using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alice_Control : MonoBehaviour
{
    // Start is called before the first frame update
   	public float speed;
	public float jump;
	private Rigidbody2D rb2d;

	private string jumpbar;

	private bool is_ground =true;
    private bool isJumping = false;

    private float moveHorizontal;
    private float moveVertical;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        jumpbar= "Jump";
    }

    void Update()
    {
        moveHorizontal = Input.GetAxis ("Horizontal")*Time.deltaTime;
        moveVertical = Input.GetAxis ("Vertical")*Time.deltaTime;

        if(Input.GetButtonDown(jumpbar) && is_ground == true)
        {
            isJumping=true;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("Ground"))
        {
            is_ground=true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("Ground"))
        {
            is_ground=false;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        Run();
        Jump();
    }

    void Run()
    {
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        float speedx = Mathf.Abs(rb2d.velocity.x);
        if(speedx < 4.0f)
        {
            rb2d.AddForce (movement * speed); 
        }

    }

    void Jump()
    {
        if(isJumping == true)
        {
            rb2d.AddForce(transform.up * jump);
            isJumping = false;
        }
    }
}
