using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

	public GameObject coin;
	public GameObject leftWall;
	public GameObject rightWall;
	public GameObject scoreText;

	private float leftWallPositionX;
	private float rightWallPositionX;

	private readonly float MOVE_SPEED = 2.0f;
	private Rigidbody rb;

	private ScoreScript scoreS;

	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		leftWallPositionX = leftWall.transform.position.x;
		rightWallPositionX = rightWall.transform.position.x;

		scoreS = scoreText.GetComponent<ScoreScript> ();
	}
	
	void Update () {
		// 左右のキー入力受け取り
		float x = Input.GetAxis ("Horizontal");
		Vector3 direction = new Vector3 (x, 0, 0);
		rb.velocity = direction * MOVE_SPEED;

		// 移動制限
		Vector3 currentPosition = this.transform.position;
		// Mathf.Clamp 最小値と最大値を設定する
		currentPosition.x = Mathf.Clamp (currentPosition.x, leftWallPositionX + 1f, rightWallPositionX -1f);
		this.transform.position = currentPosition;

		if (Input.GetKeyDown ("space")) {
			// arg0: 生成するオブジェクト, arg1: 生成する場所, arg2: 生成する角度
			Instantiate (coin, this.transform.position, this.transform.rotation);
			scoreS.SubScore (1);
		}
	}
}
