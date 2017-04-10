using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerPosition : MonoBehaviour {
    public GameObject VRPlayer;

	void Update () {

        float x = VRPlayer.transform.position.x;
        float z = VRPlayer.transform.position.z;
        this.transform.position = new Vector3(x, 0.2f, z);
	}
}
