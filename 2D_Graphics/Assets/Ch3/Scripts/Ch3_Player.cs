using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Ch3_Player : MonoBehaviour
{
    public GameObject boom_prefab;
    public float speed = 5f;
    public float jumpForce = 7f;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("isAtk");
        }
        if(Input.GetMouseButtonDown(1))
        {
            animator.SetTrigger("isHurt");
            int hp = animator.GetInteger("HP");
            animator.SetInteger("HP", hp - 20);
        }
        if(Input.GetKey(KeyCode.A) == false && Input.GetKey(KeyCode.D) == false){
            animator.SetBool("Moving", false);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            animator.SetTrigger("isJump");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
        if(Input.GetKey(KeyCode.A)){
            animator.SetBool("Moving", true);
            GetComponent<SpriteRenderer>().flipX = true;
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D)){
            animator.SetBool("Moving", true);
            GetComponent<SpriteRenderer>().flipX = false;
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    void OnHurtEnd(){
        Instantiate(boom_prefab, transform.position, Quaternion.identity);
        
    }

}
