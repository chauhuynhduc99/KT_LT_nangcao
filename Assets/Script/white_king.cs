/*using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class white_king : MonoBehaviour {
	public bool mouse_down;
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
		return transform.position;
	}

	void Click(){
		mouseHit = MousePos(); // Lấy vị trí click của chuột
		mouseHit.z = -2; // Vì game của chúng ta là 2D chính vì vậy tất cả các giá trị Z sẽ là như nhau
		if (Input.GetMouseButton(0))
			mouse_down = true; //Nếu chuột đang được bấm xuống
		else
			mouse_down = false;
	}
	// Update is called once per frame
	void Update () {
		Click();
		if(mouse_down)
		{
			transform.position = mouseHit;
		}
	}
}*/
using UnityEngine;
using System.Collections;

public class white_king : MonoBehaviour {

    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null) {
                transform.position = mousePos2D;
                hit.collider.attachedRigidbody.AddForce(Vector2.up);
            }
        }
    }

}