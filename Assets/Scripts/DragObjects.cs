using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// enables dragging for object. add this script to any gameobject that
// you want to be draggable in the game. NOTE: the object needs to have a 2D collider!
// 3d collider will cause issues! ONLY WORKS with TOUCH no mouse supported.
public class DragObjects : MonoBehaviour {

	
	// Update is called once per frame
	void Update ()
    {
        Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        Vector2 touchPos = new Vector2(wp.x, wp.y);
        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0); // get first touch since touch count is greater than zero

                if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
                {
                    // get the touch position from the screen touch to world point
                    Vector2 touchedPos = Camera.main.ScreenToWorldPoint(new Vector2(touch.position.x, touch.position.y));
                    // lerp and set the position of the current object to that of the touch, but smoothly over time.
                    transform.position = Vector2.Lerp(transform.position, touchedPos, 1);
                }
            }

        }

    }
}
