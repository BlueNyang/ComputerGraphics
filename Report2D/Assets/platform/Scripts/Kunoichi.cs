using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Kunoichi : MonoBehaviour
{
    public float walkSpeed = 2.0f;
    public float runSpeed = 4.5f;
    public float jumpForce = 15.0f;

    float speed;
    float distanceFromGround;
    new Rigidbody2D rigidbody;
    Vector2 velocity;
    Animator animator;
    internal float RayCastLength{ get{ return distanceFromGround; } }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        speed = walkSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // Get Input from Arrow Keys
        float _hozInput = Input.GetAxisRaw("Horizontal"); // -1, 0, 1
        velocity = new(_hozInput, 0f);
        velocity = velocity.normalized * speed;

        distanceFromGround = Physics2D.Raycast(transform.position, Vector2.down).distance;
        AnimatorStateInfo state;

        // Flip the Character
        if(_hozInput > 0) transform.rotation = Quaternion.Euler(0, 0, 0);
        else if(_hozInput < 0) transform.rotation = Quaternion.Euler(0, 180, 0);

        
        // When the charactor is moving or not
        if(velocity.x != 0) animator.SetBool("IsWalk", true);
        else  animator.SetBool("IsWalk", false);

        // When LeftShift is pressed, the character runs
        if(Input.GetKey(KeyCode.LeftShift)) animator.SetBool("IsRun", true);
        else animator.SetBool("IsRun", false);

        // When the character is on the air
        if(animator.GetBool("OnAir")){
            // When the character is falling
            if(rigidbody.velocity.y < -1.0f)
            {
                animator.SetBool("IsFalling", true);
                // When the distance between the character and the ground is less than 0.05f, the character lands
                if(distanceFromGround < 0.05f){
                    animator.SetBool("OnAir", false);
                    animator.SetBool("IsFalling", false);
                    animator.SetBool("IsJumped", false);
                }
            }
            else animator.SetBool("IsFalling", false);
        }
        // When the character is on the ground
        else{
            
            // When the character was on the ground, and the character is falling
            if(distanceFromGround < 1.0f) animator.SetBool("OnAir", false);
            else animator.SetBool("OnAir", true);
        }


        // if the space key is pressed, the character jumps
        if(Input.GetKeyDown(KeyCode.Space)){
            state = animator.GetCurrentAnimatorStateInfo(0);

            if(state.IsName("AM_LastFalling") == false && state.IsName("AM_Jump_Landing") == false && state.IsName("AM_Double_Jump_Up") == false){
                StartCoroutine(Jump(state));
            }
        }

        // Set the speed of the character
        state = animator.GetCurrentAnimatorStateInfo(0);
        if(state.IsName("AM_Walk") || state.IsName("AM_Idle")){
            speed = walkSpeed;
        }
        else if(state.IsName("AM_Run")){
            speed = runSpeed;
        }
        else if(state.IsName("AM_Jump_Up") || state.IsName("AM_Double_Jump_Up") || state.IsName("AM_Falling") || state.IsName("AM_LastFalling")){ }
        else {
            speed = 0.0f;
        }
    }

    IEnumerator Jump(AnimatorStateInfo state){
        animator.SetTrigger("Jump");
        animator.SetBool("OnAir", true);

        if(state.IsName("AM_Double_Jump_Up") == false)
            yield return new WaitForSeconds(3.0f / 8.0f / 1.3f);

        rigidbody.velocity = new Vector2(rigidbody.velocity.x, 0.0f);
        animator.SetBool("IsFalling", false);
        rigidbody.AddForce(new Vector2(velocity.x * 2, jumpForce), ForceMode2D.Impulse);
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("IsJumped", true);
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        rigidbody.velocity = new(velocity.x, rigidbody.velocity.y);
    }
}