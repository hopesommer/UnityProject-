using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseStatements : MonoBehaviour
{
    private int time = 15;
    private int bankaccount = 500;
    private int gradepointaverage = 3;
    private int hoursofsleep = 7;
    private int milesawayfromwork = 12;
    private int numberofwins = 7;
    // Use this for initialization
    void Start()
    {
        if (time < 12)
        {
            print("Good morning!");
        }
        else if (time == 12)
        {
            print("Lunch time!");
        }
        else if (time < 18)
        {
            print("Good evening!");
        }
        else
        {
            print("Back to work slogothor!");
        }
  
        
        if (bankaccount < 100)
        {
            print("not good");
        }
        else if (bankaccount == 100)
        {
            print("oh dear");
        }
        else if (bankaccount < 600)
        {
            print("get a job");
        }
        else
        {
            print("money is cray");
        }


        if (gradepointaverage < 4)
        {
            print("Say goodbye to Harvard");
        }
        else if (gradepointaverage == 2)
        {
            print("school is the worst");

        }
        else if (gradepointaverage < 3)
        {
            print("not the best");
        }
        else
        {
            print("grades are important");
        }


        if (hoursofsleep < 3)
        {
            print("you're going to be hecka tired");
        }
        else if (hoursofsleep == 10)
        {
            print("holla it's the weekend");
        }
        else if (hoursofsleep < 1)
        {
            print("how are you even alive?");
        }
        else
        {
            print("sleep is life");
        }


        if (milesawayfromwork < 1)
        {
            print("you don't need a car");
        }
        else if (milesawayfromwork == 27)
        {
            print("dang what a commute");
        }
        else if (milesawayfromwork < 15)
        {
            print("still not too bad of a drive");
        }
        else
        {
            print("transportaion is complicated");
        }

        if (numberofwins < 1)
        {
            print("you need more practice");
        }
        else if (numberofwins == 4)
        {
            print("Good job!");
        }
        else if (numberofwins < 2)
        {
            print("Congrats! You're improving");
        }
        else
        {
            print("practice makes perfect");
        }
    }
}
    
 




 

