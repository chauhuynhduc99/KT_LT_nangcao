using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_onclick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        obj = White_K_5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
		{
			Vector3 mouse = Input.mousePosition;
			Ray castPoint = Camera.main.ScreenPointToRay(mouse);
			RaycastHit hit;
			if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
			{
				hit.point.x = decimal.Round(hit.point.x, 0);
				hit.point.y = decimal.Round(hit.point.y, 0);
				hit.point.z = decimal.Round(hit.point.z, 0);
				obj.transform.position = hit.point;
			}
		}
    }
}
