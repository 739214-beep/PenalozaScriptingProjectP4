using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    //creating a variable for my script
    int numEnemies = 3;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
