using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMove : MonoBehaviour {
	
/* 	public float speed = 20f
	private Vector2 startPosition;
	private Rigidbody2D body2d;
	
	void Awake (){

		body2d = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		body2d.velocity = new Vector2 (speed, body2d.velocity.y);
		
	} */
	
	public float speed = 40f;  // always moving to the right

	private Vector2 startPosition;

	private Rigidbody2D body2d;
//	protected CollisionState collisionState;

    void Awake (){

		body2d = GetComponent<Rigidbody2D> ();
//		collisionState = GetComponent<CollisionState> ();
	}

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		body2d.velocity = new Vector2 (speed, body2d.velocity.y);
	}
}
