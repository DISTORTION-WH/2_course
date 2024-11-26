using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Euler : MonoBehaviour {
    public float x;
    public float z;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        x += 1f;
        z += 1f;
        transform.eulerAngles = new Vector3(x, 0, z);
    }
}
