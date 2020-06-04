using UnityEngine;
using System.Collections;

public class unit_move : MonoBehaviour {
	private bool mouse_down;
	//khởi tạo mousePos
    Vector3 mousePos;
    public float minX = -3f;
    public float maxX = 4f;
    public float minY = -3f;
    public float maxY = 4f;
	// Use this for initialization
	 void Start () {
        mousePos = transform.position;
	}
	 void OnMouseDown(){
		//hàm thực hiện khi nhấp chuột vào quân cờ được gán
		mouse_down = true;
	}
	public void OnMouseUp(){
		//hàm thực hiện khi nhả chuột ra quân cờ được gán
		mouse_down = false;
		//làm tròn tọa độ cho khớp vô ô cờ
		mousePos.x = Mathf.Round(transform.position.x);
		mousePos.y = Mathf.Round(transform.position.y);
	}
	// Update is called once per frame
	 void Update () {
	    if (Input.GetMouseButton(0) && mouse_down == true)
        {
			//cập nhật vị trí trỏ chuột vào mousePos
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos = new Vector3(Mathf.Clamp(mousePos.x, minX, maxX), Mathf.Clamp(mousePos.y, minY, maxY), -2);
		}
		//di chuyển quân cờ tới vị trí mousePos với tốc độ 5000 (gần như ngay lập tức)
        transform.position = Vector3.Lerp(transform.position, mousePos, 5000 * Time.deltaTime);
    }
}