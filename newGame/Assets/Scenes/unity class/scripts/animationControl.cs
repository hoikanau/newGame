using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationControl : MonoBehaviour
{
    public Animator zAnim;
    public bool isGrounded;
    public bool onMap = true;
    // Start is called before the first frame update
    void Start()
    {
        zAnim = GetComponent<Animator>();
        zAnim.SetBool("onMap", true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w") )
        {
            zAnim.SetBool("isWalking", true);
        }
        else
        {
            zAnim.SetBool("isWalking", false);
        }
        if(Input.GetKey("s") )  
        {
            zAnim.SetBool("isBacking", true);
        }
        else
        {
            zAnim.SetBool("isBacking", false);
        }

        if(Input.GetKey("w") && Input.GetKey(KeyCode.LeftShift))
        {
            zAnim.SetBool("isRunning", true);
        }
        else
        {
            zAnim.SetBool("isRunning", false);
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            zAnim.SetBool("isJumping", true);
            isGrounded = false;
        }
        else
        {
            zAnim.SetBool("isJumping", false);
            isGrounded = true;
        }
        if(Input.GetButtonDown("Jump") && Input.GetKey("w"))
        {
            zAnim.SetBool("isJumping", true);
            isGrounded = false;
        }
        else if(Input.GetButtonDown("Jump"))
        {
            zAnim.SetBool("isJumping", true);
            isGrounded = false;            
        }
        else
        {
            zAnim.SetBool("isJumping", false);
            isGrounded = true;
        }
    }
    // void OnTriggerEnter(Collider other)
    // {
    //     if(other.tag == "Ground")
    //     {
    //         onMap = true;
    //     }
    // }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "offMap")
        {
            zAnim.SetBool("onMap", false);
            // zAnim.SetBool("isWalking", false);
            // zAnim.SetBool("isJumping", false);
            // zAnim.SetBool("isRunning", false);
        }
    }
}
