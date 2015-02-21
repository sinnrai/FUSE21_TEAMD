﻿using UnityEngine;
using System.Collections;

public class DragAndDrop : MonoBehaviour 
{
	private Vector3 ScreenPoint;
	private Vector3 offset;

	void OnMouseDown()
	{
		this.ScreenPoint = Camera.main.WorldToScreenPoint(transform.position);
        this.offset = transform.position - Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, ScreenPoint.y, Input.mousePosition.y));
	}

	void OnMouseDrag()
	{
		Vector3 currentScreenPoint = new Vector3 
                                     (Input.mousePosition.x, ScreenPoint.y, Input.mousePosition.y);
		Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
        transform.position = currentPosition;
	}
}
