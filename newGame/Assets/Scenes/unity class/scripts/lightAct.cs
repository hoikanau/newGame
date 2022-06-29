using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightAct : MonoBehaviour
{
    public GameObject Player;
    public Light lightingCheck;
    public AudioSource juke;
    // Start is called before the first frame update
    void Start()
    {
        lightingCheck = GetComponent<Light>();
        juke = Player.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        lightingCheck.intensity = 0f;
        juke.Play();
    }

    void OnTriggerExit(Collider other)
    {
        lightingCheck.intensity = 1f;
        juke.Stop();
    }
}