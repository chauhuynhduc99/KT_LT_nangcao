using UnityEngine;
using System.Collections;

public class white_king : MonoBehaviour {
	private bool mouse_down;
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
		mouse_down = true;
	}
	void OnMouseUp(){
		mouse_down = false;
		mousePos.x = Mathf.Round(transform.position.x);
		mousePos.y = Mathf.Round(transform.position.y);
	}
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButton(0) && mouse_down == true)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos = new Vector3(Mathf.Clamp(mousePos.x, minX, maxX), Mathf.Clamp(mousePos.y, minY, maxY), -2);
        }
        transform.position = Vector3.Lerp(transform.position, mousePos, 5000 * Time.deltaTime);
    }
}