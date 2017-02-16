using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwtichStatements : MonoBehaviour {
    private int time = 10;
    public string animal = "alligator";
    private string phrase;
    private bool exists = true;
    public string instrument = "bassoon";
    public string state = "Texas";
    private int temperature = 40;
    private int gasprice = 3;
    private string flavor = "birthday cake";
    // Use this for initialization
    //Create a switch statement for time of day
    void Start() {
        switch (animal)
        {
            case "giraffe":
                phrase = "wheezy neighbaaaah";
                break;
            case "penguin":
                phrase = "Morgan Freeman";
                break;
            case "lion":
                phrase = "roar";
                break;
            case "fox":
                phrase = "sdfsdfskwuhiudhfi";
                break;
            case "alligator":
                phrase = "\"would you like some tea with that, sir?\"";
                break;
            default:
                exists = false;
                break;
        }

        if (exists == true)
        {
            print("An " + animal + " says \"" + phrase + "\".");
        }
        else
        {
            print(animal + " does not exist.");
        }

        switch (flavor)
        {
            case "vanilla":
                phrase = "Gets boring after a while";
                break;
            case "pistachio":
                phrase = " is too out there";
                break;
            case "birthday cake":
                phrase = " is the happiest flavor that brings the most joy";
                break;
            default:
                exists = true;
                break;
        }
        if (exists == true)
        {
            print(flavor + phrase);
        }
        else
        {
            print(flavor + " is out of stock.");
        }

        switch (instrument)
        {
            case "trumpet":
                phrase = "I always have the best solos";
                break;
            case "clarinet":
                phrase = "I am the cat in Peter and the Wolf";
                break;
            case "bassoon":
                phrase = "I am the grandpa in Peter and the Wolf";
                break;
            case "flute":
                phrase = "I am the bird in Peter and the Wolf";
                break;
            case "strings":
                phrase = "We are Peter in Peter and the Wolf";
                break;
            case "oboe":
                phrase = "I am the duck in Peter and the Wolf";
                break;
            case "horns":
                phrase = "We are the wolf in Peter and the Wolf";
                break;
            default:
                exists = false;
                break;
        }

        if (exists == true)
        {
            print("An " + instrument + " says " + phrase + ".");
        }
        else
        {
            print(instrument + " does not play in this piece.");
        }


        switch (temperature)
        {
            case 50:
                print("I'm so glad it's warming up!");
                break;
            case 32:
                print("I can't believe I forgot my jacket.");
                break;
            case 20:
                print("We need a new groundhog.");
                break;
            default:
                print("Weather is the best go to for small talk.");
                break;
        }


        switch(gasprice)
        {
            case 4:
                print("Why do I live in California?");
                break;
            case 1:
                print("Miracle, something must be terrible wrong.");
                break;
            case 3:
                print("I should start riding my bike more often.");
                break;
        }



        switch (state)
        {
            case "Utah":
                print("A lot of freaking Mormons live in my perimeter");
                break;
            case "Florida":
                print("I am nice and warm even during the winter.");
                break;
            case "Texas":
                print("I am the best state ever.");
                break;
            case "Arkansas":
                print("Tell Texas to shut up.");
                break;
            default:
                print("Every state beautiful the way it is.");
                break;

        }

		switch (time)
        {
            case 9:
                print("Good morning!");
                break;
            case 12:
                print("Lunch time!");
                break;
            case 18:
                print("Time to go home!");
                break;
            default:
                print("Get back to work!");
                break;
        }
    

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
