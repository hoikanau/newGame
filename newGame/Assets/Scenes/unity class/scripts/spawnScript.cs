using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject target;

    public float coolDown;
    public float timer;

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
            var position = new Vector3(Random.Range(-6,11),1.002158f,Random.Range(-6,11));
            Instantiate(target, position, Quaternion.identity);
            timer = coolDown;
        }
    }
}
