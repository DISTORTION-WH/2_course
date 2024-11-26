using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Last : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { //крутим по игорьку
        Quaternion rot1 = Quaternion.AngleAxis(3, new Vector3(0, 1, 0));
        transform.rotation *= rot1;
    }
}
