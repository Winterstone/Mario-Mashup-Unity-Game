using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionCollision : MonoBehaviour {
	
	public GameObject powerup;
	private bool collided = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "Player"){
			if(!collided){
			Instantiate(powerup, new Vector3(316, 47, 0), Quaternion.identity);
			collided = true;
			}
		}
		
	}
}
