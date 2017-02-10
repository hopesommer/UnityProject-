using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndOperators : MonoBehaviour
{

    private float pi = 3.1415f;
    private float radius = 3.536235f;
    private float height = 7.2223f;
    private float width = 4.3335f;
    private float foundation = 3.44445f;



    // Use this for initialization
    void Start()
    {
      //an integer needs to be put into a function if you want to use it for anything
      //start and update functions are used
      //if an int is identified twice, it will identify with the most recent one
      //until you do something with the information, the values don't update 
      //find the diameter of a circle 
        float diameter = 2 * radius;
        print("The diameter of the circle with radius " + radius + " is " + diameter);

        //find the circumfrence of a circle
        float circumfrence = 2 * pi * radius;
        print("The circumfrence of the circle with radius " + radius + " is " + circumfrence);

        //find the area of a circle
        float area = pi * (radius * radius);
        print("The area of the circle with radius " + radius + " is " + area);

        // find the volume of a sphere
        float volume = (4 * pi) * ((radius * radius * radius) / 3);
        print("The volume of the sphere with radius " + radius + " is " + volume);

        //find the perimeter of a rectangle
        float perimeter = (2 * width) + (2 * height);
        print("The perimeter of a rectangle with " + width + " and " + height + " is " + perimeter);

        //find the are of a rectangle
        float areaofrectangle = width * height;
        print("The area of the rectangle with " + width + " and " + height + "is" + areaofrectangle);

        //find the are of a triangle
        float areaoftriangle = height * (foundation / 2);
        print("the area of the triangle with " + height + " and " + foundation + " is " + areaoftriangle);
    }
}

