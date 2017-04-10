using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class touchClient
{
    public GameObject gameObject;

}

public class globalState : NetworkBehaviour {

    static public globalState TheOne;
	// Use this for initialization
	void Start () {
        TheOne = this;
	}

    public bool IsServer = false;

    [SyncVar]
    public Vector3 posRight;

    [SyncVar]
    public Quaternion orRight;
	
	// Update is called once per frame
	void Update () {
		
	}

    [Command]
    void cmdTouchEvent(string ipadName, Vector2 touchPoint)
    {

    }
}
