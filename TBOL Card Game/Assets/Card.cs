using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {

    private bool sticked_to_mouse = false;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (sticked_to_mouse)
        {

        }
	}

    void OnMouseDown()
    {
        if (sticked_to_mouse)
            sticked_to_mouse = false;
        else
            sticked_to_mouse = true;
    }
}
