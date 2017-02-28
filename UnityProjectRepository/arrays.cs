using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour {

    private string[] noun1 = {"table", "whale", "cactus", "booger", "Oscar trophy",};
    private string[] verb1 = {"swimming", "laughing", "cleaning", "painting", "starving",};
    private string[] verb2 = { "farting", "pointing", "programming", "tripping", "fracking",};
private string[] verb3 = {"gardening", "stomping", "wizarding", "flipping", "gooping",};
private string[] nouns = {"weeaboos", "astronauts", "gnomes", "gophers", "nerds",};
private string[] noun2 = {"pickle", "catastrophe", "hoola hoop", "fraternity", "PTA meeting",};
private string[] noun3 = {"dog", "cat", "seahorse", "dolphin", "insect collection",};
private string[] noun4 = {"sea urchin", "hummus", "journal", "air conditioner", "window",};


  


    // Use this for initialization
void Start() {



        print("Now this is the story all about how my " 
            + noun1[Random.Range(0, noun1.Length)] + " got flipped turned upside down. And I'd like to take a minute just sit right here and tell you how I became the fresh " 
            + noun1[Random.Range(0, noun1.Length)] + " of Belair." + verb1[Random.Range(0, verb1.Length)] + " out " + verb2[Random.Range(0, verb2.Length)] + " out" + verb3[Random.Range(0, verb3.Length)] + " all cool. When a couple of " + nouns[Random.Range(0, nouns.Length)] + 
            " who were up to no good, started causing trouble in my neighborhood. I got in one little " + noun2[Random.Range(0, noun2.Length)] +
            " and my mom got scared. She said you're moving with your " + noun3[Random.Range(0, noun3.Length)] + " and " + noun4[Random.Range(0, noun4.Length)] + " in Belair.");
    





    }

    // Update is called once per frame
    void Update () {
		
	}
}
