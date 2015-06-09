using UnityEngine;
using System.Collections;

public class Cylinder : MonoBehaviour {
	public GameObject lines;
	public int MAX_MOVE = 8;
	int rightCnt = 0,leftCnt = 0;
	bool canMoveR = false, canMoveL = false;

	// Use this for initialization
	void Start () {
		//  Debug.Log(lines.GetComponent<MainCamera>());
	}
	
	// Update is called once per frame
	void Update () {
		if (canMoveR) {
			if (Input.GetKey ("right")) {
				transform.Rotate (new Vector3 (1, 0, 0));
				rightCnt++;
				leftCnt--;
			}
		}
		if (canMoveL) {
			if (Input.GetKey ("left")) {
				transform.Rotate (new Vector3 (-1, 0, 0));
				leftCnt++;
				rightCnt--;
			}
		}

		if (rightCnt > MAX_MOVE) {
			canMoveR = false;
		} else {
			canMoveR = true;
		}
		if (leftCnt > MAX_MOVE) {
			canMoveL = false;
		} else {
			canMoveL = true;
		}

	}


	void OnCollisionStay(){
	}

	void OnCollisionExit(){
	}
}
