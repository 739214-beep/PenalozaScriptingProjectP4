using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    //creating my variables for my script
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest()
    {
        // this ones gonna check the temperature of my coffee
        if (coffeeTemperature > hotLimitTemperature)
        {
           
            Debug.Log("Coffee is too hot.");
        }
        //thios one is going to check if the coffee is too cold
        else if (coffeeTemperature < coldLimitTemperature)
        {
            Debug.Log("Coffee is too cold.");
        }
        // this ones gonna check if the coffee is just right
        else
        {
            Debug.Log("Coffee is just right.");
        }
    }
}