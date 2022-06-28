using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchWall : MonoBehaviour
{
    public int enterCount = 0, exitCount = 0;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Wall touched!");
        enterCount++;
        Debug.Log("You've touched the wall " + enterCount + " times!");
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Bye Wall");
        exitCount++;
        Debug.Log("You've exited the wall " + exitCount + " times!");
    }

}
