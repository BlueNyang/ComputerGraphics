using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch3_Kunoichi : MonoBehaviour
{
    public float walkSpeed = 2.0f;
    public float runSpeed = 4.5f;
    float speed = 1.0f;
    public float jumpForce = 10.0f;
    Vector2 velocity;
    new Rigidbody2D rigidbody;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float _hozInput = Input.GetAxisRaw("Horizontal"); // -1, 0, 1
        velocity = new(_hozInput, 0f);
        velocity = velocity.normalized * speed;

        if(_hozInput > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if(_hozInput < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if(velocity.x != 0)
        {
            animator.SetBool("IsWalk", true);
        }
        else
        {
            animator.SetBool("IsWalk", false);
        }

        if(Input.GetKey(KeyCode.LeftShift)){
            animator.SetBool("IsRun", true);
            speed = runSpeed;
        }
        else{
            animator.SetBool("IsRun", false);
            speed = walkSpeed;
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            animator.SetTrigger("Jump");
            rigidbody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }


        //rigidbody.velocity = velocity;
    }
    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        rigidbody.velocity = new(velocity.x, rigidbody.velocity.y);
    }
}
