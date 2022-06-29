using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpSound : MonoBehaviour
{
    public GameObject Player;
    public AudioSource wooshSound;
    public bool jumpCheck = false;
    // Start is called before the first frame update
    void Start()
    {
        wooshSound = Player.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        wooshSound.Play();
    }
    void jumpWoosh()
    {
        jumpCheck = false;
        // wooshSound.Play(jumping.mp3); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpCheck = true;
            // jumpWoosh();
        }
        wooshSound.Stop();
    }
}
