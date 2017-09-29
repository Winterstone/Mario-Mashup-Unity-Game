/*
 * InputManager is able to take inputs from Unity and convert them 
 * into buttons that our game can use this class will store whether 
 * the button has been pressed or released. 
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonState{
	public bool value;  // stores whether or not button has been pressed
	public float holdTime = 0;  // how long a button has actually been pressed
}

//Every behavior will point to InputState and will need to know
//the Direction player is facing.  Directions will hold this infomation
//for other behaviors.
public enum Directions{
	Right = 1,
	Left = -1
}

public class InputState : MonoBehaviour {

	public Directions direction = Directions.Right;
	public float absVelX = 0f;
	public float absVelY = 0f;

	private Rigidbody2D body2d;

	private Dictionary<Buttons, ButtonState> buttonStates = new Dictionary<Buttons,ButtonState>();

	void Awake () {
		body2d = GetComponent<Rigidbody2D> ();
	}

	// Special method that's reserved for making physics calculations.
	// Unlike the regular update, FixedUpdate is called at a limited 
	// number of intervals during the Update loop.
	void FixedUpdate(){
		absVelX = Mathf.Abs (body2d.velocity.x);
		absVelY = Mathf.Abs (body2d.velocity.y);
	}

	public void SetButtonValue(Buttons key, bool value){

		if (!buttonStates.ContainsKey (key))
			buttonStates.Add (key, new ButtonState ());

		var state = buttonStates [key];
		// We can check whether a button has been released or if a button is still down, 
		// by testing the state value vs the value that's coming in when we set the button value. 
		if (state.value && !value) {
			state.holdTime = 0;
		} else if (state.value && value) {
			// deltaTime represents the number of milliseconds from one frame to another. 
			// If the time is set to zero, let's say the game is paused, this value is going 
			// to be zero. If the game is running, correctly, at it's full frame rate, it'll 
			// be a varying number of milliseconds.
			state.holdTime += Time.deltaTime;
		}


		state.value = value;
	}

	public bool GetButtonValue(Buttons key){
		if (buttonStates.ContainsKey (key))
			return buttonStates [key].value;
		else
			return false;

	}

	public float GetButtonHoldTime(Buttons key){
		if (buttonStates.ContainsKey (key))
			return buttonStates [key].holdTime;
		else
			return 0;

	}
}
