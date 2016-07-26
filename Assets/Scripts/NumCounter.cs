using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumCounter : MonoBehaviour {

	private readonly int INIT_NUM = 0;
	private int currentNum;
	private Text numText;

	void Start () {
		numText = this.GetComponent<Text> ();
		UpdateText (INIT_NUM);
		currentNum = INIT_NUM;
	}

	void UpdateText(int n) {
		numText.text = n.ToString ();
	}

	public void AddNum(int n) {
		currentNum += n;
		UpdateText (currentNum);
	}
	
}
