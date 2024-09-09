using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame
    public int timer = 100;
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            if (timer <= 0)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timer = 100;
            }
        }

        timer --;
    }
}
