using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corescript : MonoBehaviour {
    public float bulletSpeed;

    public AudioSource boom;


   public GameObject explosion1;

    private MeshRenderer bul_rend;


    // Use this for initialization
    void Start () {
        Destroy(gameObject, 5f);
        bulletSpeed = 1.2f;
        bul_rend = GetComponent<MeshRenderer>();
        gameObject.transform.Rotate(0, 180, 90 );
        explosion1.transform.localScale = Vector3.one * 0.2f;
        boom = gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.TransformDirection(Vector3.up.normalized * bulletSpeed);
    }
    void OnCollisionEnter(Collision col)
    { 
        Instantiate(explosion1, gameObject.transform);
        bul_rend.enabled = false;
        bul_rend.gameObject.GetComponent<AudioSource>().PlayOneShot(bul_rend.gameObject.GetComponent<AudioSource>().clip);
    }
}
