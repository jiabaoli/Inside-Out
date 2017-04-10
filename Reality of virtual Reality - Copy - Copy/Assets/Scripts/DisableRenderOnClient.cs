using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Rendering;

public class DisableRenderOnClient : NetworkBehaviour
{
    
	void Update() {
        MeshRenderer renderer = this.GetComponent<MeshRenderer>();
        if (!isServer)
        {
            renderer.shadowCastingMode = ShadowCastingMode.ShadowsOnly;
            Debug.Log(isServer + "shadow only!");
           
        }
        else
        {
            renderer.shadowCastingMode = ShadowCastingMode.On;
            Debug.Log(isServer + "Render On!");
        }

    }
	
}
