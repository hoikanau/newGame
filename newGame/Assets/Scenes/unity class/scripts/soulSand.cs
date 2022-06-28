using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soulSand : MonoBehaviour
{
    public GameObject Player;
    public Movement moving;
    // Start is called before the first frame update
    void Start()
    {
        moving = Player.GetComponent<Movement>();
    }

    void OnTriggerEnter(Collider other)
    {
        moving.Speed = moving.Speed/2;
        moving.sprintSpeed = moving.sprintSpeed/2;
    }

    void OnTriggerExit(Collider other)
    {
        moving.Speed = 3.5f;
        moving.sprintSpeed = 10f;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
