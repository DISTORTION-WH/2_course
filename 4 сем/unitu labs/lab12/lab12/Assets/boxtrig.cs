using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxtrig : MonoBehaviour {
    public Light Point;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    void OnTriggerEnter(Collider col)
    {
        if (col.name == "player")
        {
            Point.enabled = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.name == "player")
        {
            Point.enabled = false;
        }
    }



}
