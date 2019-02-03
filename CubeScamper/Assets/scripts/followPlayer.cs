using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {

    public Transform player;
    // Vector3 store 3 number
    public Vector3 offset;

	void Update () {
        // smaller transform refer to transform of this object
        transform.position = player.position + offset;
	}
}
