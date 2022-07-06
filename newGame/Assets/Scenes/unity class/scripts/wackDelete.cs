using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wackDelete : MonoBehaviour
{
    public float radius = 25.0f;
    public float coolDown;
    public float timer;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 0)
        {
            timer = 0;
        }
        if (timer == 0)
        {
            Destroy(gameObject);
            timer = coolDown;
        }   

        if(((this.gameObject.transform.position - GameObject.FindGameObjectWithTag("Player").transform.position).sqrMagnitude < radius) && Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Destroyed");
            FindObjectOfType<soundManagerScript>().Play("woosh");
            Destroy(gameObject);
        }
    }
}
