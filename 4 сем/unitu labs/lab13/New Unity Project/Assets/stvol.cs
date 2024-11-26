using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stvol : MonoBehaviour
{
    AudioSource movementSound;

    public AudioSource shoot;
    public GameObject core;
    public float verticalOffset = 2.0f;
    //public Vector3 vec = new Vector3(0.0f, 0.001f, 0.0f);

    void Start()
    {
         shoot = gameObject.GetComponent<AudioSource>();
        movementSound = GetComponent<AudioSource>();

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 forwardofstvol = transform.position + transform.TransformDirection(Vector3.forward.normalized ) ;
            Vector3 offsetPosition = new Vector3(forwardofstvol.x  , forwardofstvol.y , forwardofstvol.z ) ;
           // offsetPosition -= vec;
            GameObject newbullet = Instantiate(core, offsetPosition, transform.rotation);
            shoot.PlayOneShot(shoot.clip);



           
        }
        if ((Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0) && !movementSound.isPlaying)
        {
            movementSound.Play();
        }
        if (Input.GetAxis("Mouse X") == 0 && Input.GetAxis("Mouse Y") == 0 && movementSound.isPlaying)
        {
            movementSound.Stop();
        }
    }
}
