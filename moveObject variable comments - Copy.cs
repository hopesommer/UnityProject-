using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour {
    public float horizontalSpeed = .2f;
    public float verticalSpeed = .2f;
    //there are 5 data types we discussed today: int, float, double, string and bool
    //bool is true or false statement, float can store beyond whole numbers, string letters can 
    //contain letters and other characters, and integers are whole numbers 

    // Use this for initialization
    void Update () {
        if (Input.GetKey (KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(-horizontalSpeed, 0, 0);
        }
		if (Input.GetKey (KeyCode.RightArrow))
        {
            gameObject.transform.Translate(horizontalSpeed, 0, 0);
        }
        if (Input.GetKey (KeyCode.UpArrow))
        {
            gameObject.transform.Translate(0, verticalSpeed, 0);
        }
        if (Input.GetKey (KeyCode.DownArrow))
        {
            gameObject.transform.Translate(0, -verticalSpeed, 0);

        }
	}
		// Update is called once per frame
 
		
	}

