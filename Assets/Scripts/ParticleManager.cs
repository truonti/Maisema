using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// spawns particles to location where player taps with finger
public class ParticleManager : MonoBehaviour {

    public GameObject particlesToSpawn; // our particles that we want to spawn (set from editor)

	// Update is called once per frame
	void Update () {
		
        if(Input.touchCount > 0) // dont spawn too fast
        {
            Touch touch = Input.GetTouch(0); // we get the touch
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position); // we get the touch position

            if (touch.phase == TouchPhase.Began) // if touched we spawn with instantiate method
                Instantiate(particlesToSpawn, touchPos, Quaternion.identity); // spawns particles to touch location
        }
	}
}
