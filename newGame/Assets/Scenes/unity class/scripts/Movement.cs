using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    public float sprintSpeed = 10f;
    public Rigidbody RB;
    public float jumpForce = 3f;
    public bool onGround = true;
    // Update is called once per frame
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }
    
    void Update()   
    {
        PlayerMovement();
        Jump();
    }

    void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        if (Input.GetKey(KeyCode.LeftShift)){
            Vector3 playerMovement = new Vector3(horizontal,0f,vertical) * sprintSpeed * Time.deltaTime;   
            transform.Translate(playerMovement, Space.Self);
        }
        else
        {
            Vector3 playerMovement = new Vector3(horizontal,0f,vertical) * Speed * Time.deltaTime;
            transform.Translate(playerMovement, Space.Self);
        }
        
        
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && onGround)
        {
            RB.AddForce(new Vector3(0,jumpForce,0), ForceMode.Impulse);
            onGround = false;
            FindObjectOfType<soundManagerScript>().Play("jumped");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ground")
        {
            onGround = true;
        }
        // if(other.tag == "Ground" && other.gameObject.layer == 8)
        // {
        //     FindObjectOfType<soundManagerScript>().Play("grassSound");
        // }

    }

}
