using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //creating a boolian variable for my do while loop
        bool shouldContinue = false;

        //my do while loop that will print "Hello World" to the console as long as the boolian variable is true
        do
        { 
        print("Hello World");
        }
        while (shouldContinue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
