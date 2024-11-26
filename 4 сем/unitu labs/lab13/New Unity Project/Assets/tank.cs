using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour {
    public GameObject bashnya; 
    public GameObject stvolPivot;
    Transform bash;         
    Transform stv;        
    float TankMoveSpeed = 0.01f;           
    float RotateSpeed = 1f;    



    AudioSource movementSound;

    // Use this for initialization
    void Start () {
        bash = gameObject.transform.Find("bashnya");
        stv = gameObject.transform.Find("stvolPivot");
        movementSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update () {
        float z = Input.GetAxis("Vertical")/10;         
        transform.Translate(z, 0, 0);                       

        float x = Input.GetAxis("Horizontal") / 2;    
        transform.Rotate(0, 0, x);

        float h = Input.GetAxis("Mouse X");
        bash.Rotate(0f, 0f, h * RotateSpeed);   
           
        stvolPivot.transform.Rotate(0f, -Input.GetAxis("Mouse Y"), 0f);
  

       
        if ((Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) && !movementSound.isPlaying)
        {
            movementSound.Play();
        }
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0 && movementSound.isPlaying)
        {
            movementSound.Stop();
        }

    }
}
