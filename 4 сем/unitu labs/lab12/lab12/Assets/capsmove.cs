using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsmove : MonoBehaviour
{
    public float keyboardMoveSpeed = 1;
    public float mouseMoveSpeed = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
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
    }
}