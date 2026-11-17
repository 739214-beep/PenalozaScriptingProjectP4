using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModiifiers : MonoBehaviour
{
    //adding a public variable to this class
    public int alpha = 5;
    //adding a private avriable to the class
    private int beta = 0;
    private int gamma = 5;
    //add acsess to another class
    private AnotherClass myOtherClass;
    // Start is called before the first frame update
    void Start()
    {
        //change tyhe starting value of the apple
        alpha = 29;
        //i can change or accsess aniother class
        myOtherClass = new AnotherClass();
        //i am going to use the method in another class
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }

    void Example (int pens, int crayons)
    {
        //creates a local variable to the method
        int answer;
        //multiply the 2 parameters and assign it to the local variable
        answer = pens * crayons * alpha;
        //print the local variable to the console
        Debug.Log(answer);
    }
}
