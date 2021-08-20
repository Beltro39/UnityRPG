using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    // Start is called before the first frame update
    public float speed= 1.0f;
    private Rigidbody2D rb2d;
    Animator animator;
    void Start()
    {
        rb2d= GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
          //float h = Input.GetAxis("Horizontal");
        Vector2 move= Vector2.zero;

        if(Input.GetKey(KeyCode.UpArrow)){
            move.y= 1;
            animator.SetBool("Up", true);
             animator.SetBool("Down", false);
             animator.SetBool("Left", false); 
              animator.SetBool("Rigth", false); 
            animator.SetFloat("Speed", 1.0f);
            
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            move.y= -1;
            animator.SetBool("Down", true);
            animator.SetBool("Up", false);
            animator.SetBool("Left", false); 
             animator.SetBool("Rigth", false); 
            animator.SetFloat("Speed", 1.0f);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            move.x= 1;
             animator.SetBool("Up", false);
             animator.SetBool("Down", false);
             animator.SetBool("Left", false);
             animator.SetBool("Rigth", true); 
             animator.SetFloat("Speed", 1.0f);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            move.x= -1;
             animator.SetBool("Up", false);
             animator.SetBool("Down", false);
             animator.SetBool("Left", true); 
             animator.SetBool("Rigth", false); 
             animator.SetFloat("Speed", 1.0f);
        }
        else{
             animator.SetFloat("Speed", 0.0f);
            
        }
        rb2d.MovePosition((Vector2)this.transform.position + (move*speed*Time.deltaTime));
        

    }
}
