using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;

    // helpful place is Unity Docs Player Input, Unity Scripting - API
    // Use this for initialization
    void Start ()
    {
        StartGame();
        //variables: they are typed with the first word as lowercase and the second word as upper case. likeThis
         //int means integer or a whole number. 
         //Float is a number with decimal places. we have to put an 'f' at the end
         //bool means something is true or false.
         //string assigns a data value
	}

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Peace! Welcome to the magical Number Wizard!");
        Debug.Log("Please pick a number, but keep it a secret!");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number if higher or lower than: " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You're correct!");
            StartGame();
        }
	}
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your guess higher than " + guess);
    }
}
