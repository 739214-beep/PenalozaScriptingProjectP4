using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    //ADDING 2 PUBLIC VARIABLES
    public int apples = 5;
    public int bananas = 10;

    //adding 2 private variiables
    private int stapler;
    private int sellotape;

    //creating a method that takes in 2 parameters
    public void FruitMachine (int a, int b)
    {
        //create a lozal variable to the mehjtod
        int answer;
        //add the 2 pasrameters and assign it to the local variavble
        answer = a + b;
        //add the 2 pasrameters and assign it to the local variavble
        Debug.Log("Fruit Machine total: " + answer);
    }
    //creating a method that takes in 2 parameters
    private void OfficeSort(int a, int b)
    {
        //create a lozal variable to the mehjtod
        int answer;
        //add the 2 pasrameters and assign it to the local variavble
        answer = a + b;
        //add the 2 pasrameters and assign it to the local variavble
        Debug.Log("Office Supplies total: " + answer);
    }

    // Start is called before the first frame update
    void Start()
    {
         
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
