/*
 *  This class connects up the animations and will know the state of 
 *  each of the behaviors and be able to update the display accordingly. 
*/
using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	private InputState inputState;
	private Walk walkBehavior;
	private Animator animator;
	private CollisionState collisionState;


	void Awake () {
		inputState = GetComponent<InputState> ();
		walkBehavior = GetComponent<Walk> ();
		animator = GetComponent<Animator> ();
		collisionState = GetComponent<CollisionState> ();

	}

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		//change to idle state
		if (collisionState.standing) {
			ChangeAnimationState (0);
		}
		//change to walk state
		if (inputState.absVelX > 0) {
			ChangeAnimationState (1);
		}
		//change to jump state
		if (inputState.absVelY > 0) {
			ChangeAnimationState (2);
		}


	}

	void ChangeAnimationState(int value){
		animator.SetInteger ("AnimState", value);
	}
}
