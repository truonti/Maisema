using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoristepalloManager : MonoBehaviour
{
    public GameObject koristepallo; // object (ornate ball) that we want to spawn
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        Vector2 touchPos = new Vector2(wp.x, wp.y);

        // on touch to tree hollow
        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
        {
            if (Input.touchCount == 1)
            {
                Instantiate(koristepallo, touchPos, Quaternion.identity); // spawns an ornate ball to the tree hollow at touch position
            }

        }
    }
}
