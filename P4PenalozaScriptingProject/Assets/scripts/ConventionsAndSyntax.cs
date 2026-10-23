using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //thisa comment uis there to rfem8ind tgbhe posistion oif the x posistioom in ther console
        Debug.Log(transform.position.x);

    }

    // Update is called once per frame
    void Update()
    {
        //this if statement is goijng to check the hight of my game object
        if(transform.position.y > 5f)
        {
            Debug.Log("I am about to hit the grround! D:");
        }
        else
        {
            Debug.Log("I am not gonna hit anything anymore! :D");
        }
    }
}

