﻿using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void OnCollisionEnter(Collision collision)
    {
        //get the direction of impact, then get the position of the target, then make the decal spawn at the location of target + 2x offset. (so it looks like blood is coming out the back of them based on where you hit them)
        Vector3 Impact = collision.transform.InverseTransformPoint(transform.position);
        Vector3 floorDecal = collision.transform.position - Impact;
        floorDecal.y = 0.01f;
        GameObject monster = (GameObject)Instantiate(Resources.Load("BloodSplatter"), floorDecal, Quaternion.Euler(0.0f, Random.Range(0.0f, 360.0f),0.0f));
    }
    // Update is called once per frame
    void Update () {
	
	}
}
