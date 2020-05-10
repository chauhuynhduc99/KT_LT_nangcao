using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class white_king : MonoBehaviour {
	public bool mouse_down;
	public PhysicMaterial blockPhysicMaterial; // Loại thuộc tính physic của khối
	private Vector3 mouseHit; // Vị trí chuột khi nhấn
	// Use this for initialization
	void Start () {

	}
	public Vector3 MousePos(){
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(ray, out hit)) {
			return hit.point;
		}
		return Vector3.zero;
	}

	void OnMouseDown(){
		mouseHit = MousePos(); // Lấy vị trí click của chuột
		mouseHit.z = 0; // Vì game của chúng ta là 2D chính vì vậy tất cả các giá trị Z sẽ là như nhau
		mouse_down = true; //Nếu chuột đang được bấm xuống
	}
	void OnMouseUp(){
		mouse_down = false; //Khi nhả chuột, dừng động tác kéo.
	}
	// Update is called once per frame
	void Update () {
		if(mouse_down)
		{ // Như đã nói ở trên, đây là khi bắt đầu thực hiện Drag
			transform.position = mouseHit;
		}
	}
	
}