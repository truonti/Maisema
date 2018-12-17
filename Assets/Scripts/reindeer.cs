using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reindeer : MonoBehaviour {

    Animator m_Animator;

    // Use this for initialization
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>(); // instantiating animator
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        Vector2 touchPos = new Vector2(wp.x, wp.y);

        // on touched
        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
        {
            if (Input.touchCount >= 1)
            {
                m_Animator.SetTrigger("active"); // sets animation on from animator
            }
            else m_Animator.ResetTrigger("active"); // sets animation to idle

        }
        else m_Animator.ResetTrigger("active"); // sets to idle

    }

    public void animationEnded()
    {
        m_Animator.SetBool("idling", true);
    }
}

