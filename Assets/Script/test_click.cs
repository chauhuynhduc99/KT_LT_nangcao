using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_click : MonoBehaviour
{
	Vector3 mousePos;
	public float moveSpeed = 5000;
    public float minX = -3f;
    public float maxX = 4f;
    public float minY = -3;
    public float maxY = 4;
    // Start is called before the first frame update
    void Start()
    {
        mousePos = transform.position;
		
    }

    // Update is called once per frame
    void Update()
	{
		if (Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
			{
                mousePos = new Vector3(Mathf.Clamp(mousePos.x, minX, maxX), Mathf.Clamp(mousePos.y, minY, maxY), -2);
                hit.collider.attachedRigidbody.AddForce(Vector2.up);
            }
            mousePos = new Vector3(Mathf.Clamp(mousePos.x, minX, maxX), Mathf.Clamp(mousePos.y, minY, maxY), -2);
        }
        transform.position = mousePos;
	}
}