using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxtrig2 : MonoBehaviour
{
    public Light Spot;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }




    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.name == "player")
        {
            Spot.transform.Rotate(0, 10, 0);
        }

    }


}
