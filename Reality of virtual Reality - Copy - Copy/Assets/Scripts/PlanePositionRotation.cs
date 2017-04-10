using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePositionRotation : MonoBehaviour {

    public Camera Cam;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        
        Vector3 p = Cam.transform.position;
        Vector3 rayv = Cam.transform.forward;
        rayv = rayv.normalized;
        gameObject.transform.position = 10 * rayv + p;
        gameObject.transform.rotation = Cam.transform.rotation;

        //Vector3 pLane = Cam.GetComponent<Camera>().
        //gameObject.transform.position = 
    }
}
