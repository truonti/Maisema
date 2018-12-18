using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elfManager : MonoBehaviour {

    public GameObject elf;

    public GameObject elfSpawnLocation;
    
    // Use this for initialization
	void Start ()
    {
        Instantiate(elf, elfSpawnLocation.transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void showElf()
    {
        elf.SetActive(true);
    }
}
