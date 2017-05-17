using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacija_XY : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(5, 20, 30) * Time.deltaTime);
    }
}
