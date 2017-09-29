using UnityEngine;
using System.Collections;

//Names for buttons which will map to inputs
//in Unity Edit -> Project Settings -> Input through 
//InputManager component
public enum Buttons{
	Right,
	Left,
	Up,
	Down,
	A,
	B
}

public enum Condition{
	GreaterThan,
	LessThan
}


[System.Serializable]
public class InputAxisState{
	public string axisName;
	public float offValue;
	public Buttons button;
	public Condition condition;

	// Convert the axis state to a button press and get a value out to determine 
	// whether the button is being pressed or not. In order to do this, test the value 
	// that we're getting back from the axis itself, inside of our axis state. 
	// Use enum called Condition andkeep track of the value of greater than or less than as it 
	// relates to the off value of the InputAxisState.
	public bool value{
		get{
			var val = Input.GetAxis (axisName);

			switch(condition){
			case Condition.GreaterThan:
				return val > offValue;
			case Condition.LessThan:
				return val < offValue;
			}

			return false;

		}

	}
}

public class InputManager : MonoBehaviour {

	public InputAxisState[] inputs;
	public InputState inputState;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	// loop through all the inputs that have been mapped on the InputManager 
	// and pass those values directly into the inputState and use the button enum as a way of 
	// abstracting which button is actually pressed.
	void Update () {
			foreach (var input in inputs) {
				inputState.SetButtonValue (input.button, input.value);
			}
	}
}
