using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowballManager : MonoBehaviour
{
 
    public GameObject snowball;

    private int ballCount;

    // Update is called once per frame
    void Update()
    {
        if (ballCount < 3) // just limits how many snowballs we can spawn per game
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPos = new Vector2(wp.x, wp.y);

            // on touched
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {
                if (Input.touchCount == 1)
                {
                    Instantiate(snowball, touchPos, Quaternion.identity); // spawns snowball to touch position
                    ballCount++;
                }
            }

        }
    }


}
