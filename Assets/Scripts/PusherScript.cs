using UnityEngine;
using System.Collections;

public class PusherScript : MonoBehaviour {
	private Vector3 initPosition;
	private Vector3 newPosition;

	void Start () {
		initPosition = this.transform.position;
	}
	
	void Update () {
		// 反復移動はsin関数を使う
		float x = initPosition.x;
		float y = initPosition.y;
		float z = initPosition.z + Mathf.Sin (Time.time) * 2f;
		newPosition = new Vector3(x, y, z);
		this.GetComponent<Rigidbody> ().MovePosition (newPosition);
	}
}
