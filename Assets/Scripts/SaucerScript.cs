using UnityEngine;
using System.Collections;

public class SaucerScript : MonoBehaviour {

	public GameObject scoreText;
	private ScoreScript scoreS;

	private AudioSource getSE;

	void Start() {
		scoreS = scoreText.GetComponent<ScoreScript> ();
		getSE = this.GetComponent<AudioSource> ();
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Coin") {
			Destroy (col.gameObject);
			scoreS.AddScore (2);
			getSE.PlayOneShot (getSE.clip);
		}
	}

}
