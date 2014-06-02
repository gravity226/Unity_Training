using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	//renderer.material.color = Color.white;
	
	private Vector3 screenPoint;

	int x;
	
	void OnMouseDown() {
		screenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position);
		Debug.Log ("MouseDown");
		x = 0;
	}
	
	void OnMouseDrag() {
		Vector3 currentScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPos = Camera.main.ScreenToWorldPoint (currentScreenPoint);
		transform.position = currentPos;
		
		if (x == 0) {
			Debug.Log ("MouseDrag");
			x = 1;
		}
	}
}