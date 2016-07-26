using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public int initScore;
	private int currentScore;
	private Text scoreText;

	void Start () {
		currentScore = initScore;
		scoreText = this.GetComponent<Text> ();
		printScore (initScore);
	}


	// スコアを減点する
	public void SubScore(int n) {
		currentScore -= n;
		printScore (currentScore);
	}

	public void AddScore(int n) {
		currentScore += n;
		printScore (currentScore);
	}

	private void printScore(int n) {
		scoreText.text = n.ToString ();
	}

}
