using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DisableProjectionOnServer : NetworkBehaviour
{
    
	void Start() {
        if (isServer)
        { 
            this.GetComponent<MeshRenderer>().enabled = false;
            Debug.Log(isServer + "disable right controller!");
           
        }
        else
        {
            this.GetComponent<MeshRenderer>().enabled = true;
            Debug.Log(isServer + "not server, enable right controller!");
        }

    }
	
}
