using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;

	// Use this for initialization
	void Start () {
        /*A “.” is within a component.Example: text with textComponent, or just textComponent.text*/
        textComponent.text = ("You're in a long, brightly lit hallway. There are guards armed with light rifles on both sides of the hallway." +
            "You are surrounded with no weapon. What do you do?");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
