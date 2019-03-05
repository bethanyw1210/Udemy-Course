using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// helpful place is Unity Docs Player Input, Unity Scripting - API
    // Use this for initialization
	void Start () {
        int max = 1000;
        int min = 1;


        //first statement. print and debug work basically the same way. debug gives us more flexability than print. debug is the more "proper" way.
        Debug.Log("Welcome to Number Wizard.");
        Debug.Log("Please pick a number, but keep it a secret!");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number if higher or lower than 500.");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");

        //variables: they are typed with the first word as lowercase and the second word as upper case. likeThis
         //int means integer or a whole number. 
         //Float is a number with decimal places. we have to put an 'f' at the end
         //bool means something is true or false.
         //string assigns a data value
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("The Up Arrow key was pressed.");
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("The Down Arrow key was pressed.");
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("The Enter key was pressed.");
        }
	}
}
