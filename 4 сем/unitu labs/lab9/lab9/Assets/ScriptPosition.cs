using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.position; //создаем переменную position типа Vector3

        position.x += 0.07f;
        position.y += 0.08f; //чтобы улетел за камеру +- через 2 секунды
        position.z += 0.1f;

        transform.position = position;
    }
}
