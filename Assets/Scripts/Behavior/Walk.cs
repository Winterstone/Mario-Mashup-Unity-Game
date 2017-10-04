using UnityEngine;
using System.Collections;

public class Walk : AbstractBehavior {

	public float speed = 50f;
	public AudioSource death;
	private Vector2 startPosition;
	private bool soundPlayed = false;
	private float tmpSpeed;
	
	// Use this for initialization
	void Start () {
	startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

	

		var right = inputState.GetButtonValue (inputButtons [0]);
		var left = inputState.GetButtonValue (inputButtons [1]);
	

		if (right || left && !soundPlayed) {
			
			if(soundPlayed){
				tmpSpeed = 0;
			}
			
			else{
				tmpSpeed = speed + 5;
			}
			

			var velX = tmpSpeed * (float)inputState.direction;

			body2d.velocity = new Vector2 (velX, body2d.velocity.y);
		}	
		
		if (transform.position.y < (startPosition.y - 100))
		{
			if(!soundPlayed)
			{
				death.Play();
				soundPlayed = true;
			}
			
			
		}
	}

}

