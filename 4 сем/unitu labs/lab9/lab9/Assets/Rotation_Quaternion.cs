using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Quaternion : MonoBehaviour
{
    Quaternion stQuaternion; //начальный угол 
    float angl = 1; //угол поворота

    // Use this for initialization
    void Start()
    {
        stQuaternion = transform.rotation; //начальный поворот 
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.AngleAxis(angl, Vector3.right);
        transform.rotation *= Quaternion.AngleAxis(angl, Vector3.forward);
    }
}