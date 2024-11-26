using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsulemove : MonoBehaviour {


    public Texture T1;
    public Texture T2;

    public float keyboardMoveSpeed = 0.01f;
    public float mouseMoveSpeed = 0.01f;

    public GameObject Cube1;
    // Use this for initialization
    void Start()
    {

    }
    
    void Update()
    {
        transform.Translate(
            keyboardMoveSpeed * Input.GetAxis("Horizontal"),
            0,
            keyboardMoveSpeed * Input.GetAxis("Vertical")
        );
        transform.Translate(
            mouseMoveSpeed * Input.GetAxis("Mouse X"),
            0,
            mouseMoveSpeed * Input.GetAxis("Mouse Y")
        );


        if (Input.GetKey(KeyCode.E))
            Cube1.gameObject.GetComponent<Renderer>().material.mainTexture = T1;

    }







    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube1")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            col.gameObject.GetComponent<Renderer>().material.mainTexture = T1;
        }
        if (col.gameObject.name == "Cube2")
        {
            col.gameObject.GetComponent<Renderer>().material.mainTexture = T2;
        }
    }
}