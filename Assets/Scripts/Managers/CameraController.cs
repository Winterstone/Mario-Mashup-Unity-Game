using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;       //Public variable to store a reference to the player game object


 

	// Use this for initialization


	// LateUpdate is called after Update each frame
	void Update () 
	{
		this.gameObject.transform.position = new Vector3(player.gameObject.transform.position.x,this.gameObject.transform.position.y,this.gameObject.transform.position.z);
	}
}