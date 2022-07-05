using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationControl : MonoBehaviour
{
    public Animator zAnim;
    // Start is called before the first frame update
    void Start()
    {
        zAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            zAnim.SetBool("isWalking", true);
        }
        else
        {
            zAnim.SetBool("isWalking", false);
        }

        if(Input.GetKey("w") && Input.GetKey(KeyCode.LeftShift))
        {
            zAnim.SetBool("isRunning", true);
        }
        else
        {
            zAnim.SetBool("isRunning", false);
        }
    }
}
