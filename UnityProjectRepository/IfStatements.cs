using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {
    private int A = 10;
    private int B = 3;
    private string name = "Hope";
    private bool awake = false;
    private string bestShowEver = "Bob's Burgers";
    private int bankAccount = 100000;
    private int collegeDebt = 10000;
    private string aGoodHouseCleaner = "windex";
    private bool aliensAreReal = true;
    private int provoWeather = 20;
    private int texasWeather = 75;
    private bool theWorldIsASquare = true;
    private int usualHoursOfSleep = 4;
    private int desiredHoursOfSleep = 7;

	// Use this for initialization
    // == means equal to, != means not equal to, < means less than, > means greater than
    // <= means less than or equal to, >= means greater than or equal to
    //use int, string and bool
    //string is a word/words, int is a number and bool is true/false 
	void Start () {
        if (desiredHoursOfSleep > usualHoursOfSleep)
        {
            print("omg a miracle");
        }

        if (theWorldIsASquare == true)
        {
            print("Stop being a hipster philosopher");
        }
        if (aliensAreReal != true)
        {
            print("almsot more heartbreaking than when you realized Santa wasn't real");
        }
        if(collegeDebt >= bankAccount)
        {
            print("McDonald's is life");
        }
        if (texasWeather <= provoWeather)
        {
            print("there is something terribly wrong and I'm moving again");
        }
        if (provoWeather < texasWeather)
        {
            print("peace out I'm moving");
        }
        if (aliensAreReal == true) 
        {
            print("beware of UFOs and carry pepper spray");
        }
        if(aGoodHouseCleaner == "windex")
        {
            print("I actually did learn something being a janitor.");
        }

        if (bankAccount > collegeDebt) 
        {
            print("Congratulations! Your degree wasn't a waste.");
        }
        if (bestShowEver != "The Bachelor")
        {
            print("finally good taste");
        }
        if (awake != true)
        {
            print("WAKE UP!");
        }
        if (awake == true)
        {
            print("Go to sleep!");
        }
        if (name != "Austin")
        {
            print(name);
        }
		if(A == B)
        {
            print("A is equal to B"); 
        }
        if (A != B)
        { 
                print("A is not equal to B");
        }
        if(A < B)
        {
            print("A is less than B");
        }
        if (A > B)
        {
            print("A is greater than B");
        }
        if (A <= B)
        {
            print("A is less than/equal to B");
        }
        if (A >= B)
        {
            print("A is greater than/equal to B");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
