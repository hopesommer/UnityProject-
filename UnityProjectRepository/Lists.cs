using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//a list is like a dynamically sized array, you don't need to know how many elements its going to have ahead of time 
//first thing to do when making a list is System.Collections.Generic;
//dictionaries work similarly to lists but there's two types 
public class Lists : MonoBehaviour
{

    public string animal;
    public List<string> zooRoster = new List<string>();
    // Use this for initialization
    void Start()
    {
        zooRoster.Add("monkey");
        zooRoster.Add("elephant");
        zooRoster.Add("alligator");
        zooRoster.Add("penguin");
        zooRoster.Add("hippo");
        zooRoster.Add("tiger");
        zooRoster.Add("panda");
        zooRoster.Add("giraffe");
    }
    public void AddAnimal()
    {
        if (animal != "")
        {
            if (zooRoster.Contains(animal) != true)
            {
                zooRoster.Add(animal);
            }
        }
    }
    public void RemoveAnimal()
    {
        if (animal != "")
        {
            if (zooRoster.Contains(animal) == true)
            {
                zooRoster.Remove(animal);
            }
        }
    }
    public void PrintAnimal()

    {
        zooRoster.ForEach(print);
    }
   
    public void ClearAnimal()
    {
        zooRoster.Clear();
    }
}
