using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Die : MonoBehaviour {

	public AudioSource SoundSource;
	public AudioClip Sound;

	void OnTriggerEnter2D(Collider2D death)
	{
		if (death.CompareTag("Player"))
		{
			SoundSource.Stop();
			SoundSource.PlayOneShot(Sound);
			StartCoroutine ("Die");
		}
	}

	IEnumerator Die () {
		yield return new WaitForSeconds (3);
		SceneManager.LoadScene ("_Scene_0");
		yield return null;
	}
}