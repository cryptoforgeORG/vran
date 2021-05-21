using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {
	
	public Button moveLeftButton;
	public Button moveRightButton;
	
	// Use this for initialization
	void Start () {
		moveLeftButton.onClick.AddListener(() => { MoveCameraLeft(); });
		moveRightButton.onClick.AddListener(() => { MoveCameraRight(); });
	}

	void MoveCameraLeft() { Debug.Log ("_enter");
		transform.position += transform.TransformDirection (Vector3.right);

	}
	void MoveCameraRight() { Debug.Log ("_enter");
		transform.position -= transform.TransformDirection (Vector3.right);
	}
}
