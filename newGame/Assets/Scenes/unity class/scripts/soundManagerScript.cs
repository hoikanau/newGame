using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class soundManagerScript : MonoBehaviour
{
    public Sound[] sounds;
    // public static AudioClip playerJumpWoosh;
    // public static AudioSource audioSrc;
    // Start is called before the first frame update
    void Awake ()
    {
        foreach (Sound s in sounds)
        {
            s.Audio = gameObject.AddComponent<AudioSource>();
            s.Audio.clip = s.clip;
            s.Audio.volume = s.volume;
            s.Audio.pitch = s.pitch;
        }
    }
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.Audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void playSound(string clip)
    {
        // switch(clip)
        // {
        //     case "jumping":
        //         audioSrc.PlayOneShot(playerJumpWoosh);
        //         break;    
        // }
    }
}
