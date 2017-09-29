using System.Collections;
using UnityEngine;

public class GetDot : MonoBehaviour {

	public int score = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D other){
		Destroy(gameObject);
		score++;
		Debug.Log ("Score: " + score);
	}
}
