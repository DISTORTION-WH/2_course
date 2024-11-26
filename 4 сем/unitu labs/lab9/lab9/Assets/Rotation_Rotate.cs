using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	//я растягивал с помощью интерфейса, но можно заюзать transform.localScale(в лабе не уточняли как)
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 1, 0); //крутим по y
    }
}
