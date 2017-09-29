/*
 * Simple Movement script
 * Added line of comment 7/21
 *
 */

using UnityEngine;
using System.Collections;

public class SimpleMovement : MonoBehaviour {

	public float speed = 5f;
	public Buttons[] input;

	private Rigidbody2D body2d;
	private InputState inputState;

	// Use this for initialization
	void Start () {
		body2d = GetComponent<Rigidbody2D> ();
		inputState = GetComponent<InputState> ();
	}
	
	// Update is called once per frame
	void Update () {

		var right = inputState.GetButtonValue (input [0]);
		var left = inputState.GetButtonValue (input [1]);
		var velX = speed;

		// when a key is been pressed, multiply the velocity X by the actual direction.
		if (right || left) {
			velX *= left ? -1 : 1;
		} else {
			velX = 0;
		}

		//change position with new x value
		body2d.velocity = new Vector2 (velX, body2d.velocity.y);
	
	}
}
