using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_GetAxis : MonoBehaviour
{
    float translateX, translateZ;
    float rotateX, rotateY;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        translateX = Input.GetAxis("Horizontal");
        translateZ = Input.GetAxis("Vertical");

        rotateX = Input.GetAxis("Mouse X");
        rotateY = Input.GetAxis("Mouse Y");

        rotateY = Mathf.Clamp(rotateY, 0, 90); //ограничиваем вращение

        transform.Translate(translateX, 0, translateZ);
        transform.Rotate(rotateX, rotateY, 0);
    }
}