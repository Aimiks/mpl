using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform spawnPoint;
	// Use this for initialization
	void Start () {
        this.transform.SetPositionAndRotation(spawnPoint.transform.position,Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
