using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    /*Array vvv
    string[] daysWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };*/

    State state; 

	// Use this for initialization
	void Start () {
        state = startingState;
        /*A “.” is within a component.Example: text with textComponent, or just textComponent.text
         state is the variable taht is allowing access to the State scriptand becaause we have access to the state class from the other script, can get access to GetStateStory*/
        textComponent.text = state.GetStateStory();
        /*This is telling unity to print out a thing from array above. The 3 tells it to print out the thing that is in the 3rd place in line, the 7 in this case
        Debug.Log(daysWeek[3]);*/

	}
	
	// Update is called once per frame
	void Update () {
        ManageState();
		
	}

    private void ManageState()
    {
        /* var is the same as saying State[], works with arrays*/
        var nextStates = state.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        textComponent.text = state.GetStateStory();
    }
}
