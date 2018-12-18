using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elf : MonoBehaviour {


    Animator m_Animator;
    
    // Use this for initialization
    void Start ()
    {
        m_Animator = gameObject.GetComponent<Animator>(); // instantiating animator
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
