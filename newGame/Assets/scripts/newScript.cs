using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            Debug.Log("Pressed D key!");
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            Debug.Log("Pressed A key!");
        }

        if (Input.GetAxis("Mouse X") > 0)
        {
            Debug.Log("Moved Mouse to the right!");
        }
        else if (Input.GetAxis("Mouse X") < 0)
        {
            Debug.Log("Moved mouse to the left!");
        }

        if (Input.GetAxis("Mouse Y") > 0)
        {
            Debug.Log("Moved Mouse to the up!");
        }
        else if (Input.GetAxis("Mouse Y") < 0)
        {
            Debug.Log("Moved mouse to the down!");
        }        
    }
}
