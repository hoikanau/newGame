using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    public float sprintSpeed = 10f;
    // Update is called once per frame
    void Update()   
    {
        PlayerMovement();
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



}
