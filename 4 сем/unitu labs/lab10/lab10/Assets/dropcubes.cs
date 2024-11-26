using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropcubes : MonoBehaviour {
    public GameObject Sphereprefub;

    MeshRenderer meshRenderer;
    float minX, maxX;
    float minZ, maxZ;
    float nX, nY, nZ;

    // Use this for initialization
    void Start ()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>(); 
 
        minX = meshRenderer.bounds.min.x; 
        maxX = meshRenderer.bounds.max.x; 
        minZ = meshRenderer.bounds.min.z;
        maxZ = meshRenderer.bounds.max.z;

        nY = gameObject.transform.position.y + 5;  
    }

    // Update is called once per frame
    void Update ()
    {
        nX = Random.Range(minX, maxX);
        nZ = Random.Range(minZ, maxZ);

        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            newCube.transform.position = new Vector3(nX, nY, nZ);
            newCube.AddComponent<Rigidbody>(); 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Sphereprefub, new Vector3(nX, nY, nZ), Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back);
        }
    }
}

