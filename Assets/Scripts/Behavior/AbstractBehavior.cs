using UnityEngine;
using System.Collections;

public class AbstractBehavior : MonoBehaviour {

	public Buttons[] inputButtons;
	public MonoBehaviour[] disabledScripts;

	protected InputState inputState;
	protected Rigidbody2D body2d;
	protected CollisionState collisionState;

	protected virtual void Awake (){
		inputState = GetComponent<InputState> ();
		body2d = GetComponent<Rigidbody2D> ();
		collisionState = GetComponent<CollisionState> ();
	}

	protected virtual void ToggleScripts(bool value){
		foreach (var script in disabledScripts)
			script.enabled = value;

	}
}
