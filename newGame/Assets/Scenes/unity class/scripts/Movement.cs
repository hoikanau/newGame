using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;

    // Update is called once per frame
    void Update()   
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(horizontal,0f,vertical) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }



}
