using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowmanBuilder : MonoBehaviour {

    List<GameObject> snowmanParts = new List<GameObject>();
    private int index = 0;

    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;

    public GameObject face;
    public GameObject hands;
    public GameObject buttons;

    private void Start()
    {
        snowmanParts.Add(ball1);
        snowmanParts.Add(ball2);
        snowmanParts.Add(ball3);
        snowmanParts.Add(face);
        snowmanParts.Add(hands);
        snowmanParts.Add(buttons);
    }

    public void buildSnowman()
    {
        snowmanParts[index].SetActive(true);
        index++;
    }
    
}
