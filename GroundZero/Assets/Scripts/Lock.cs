using UnityEngine;
using System.Collections;

public class Lock : MonoBehaviour {
    public Transform target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void LateUpdate() {
       // transform.rotation = Quaternion.Euler(new Vector3(75, 180, 0));
        Vector3 offsetVector = target.position;
        offsetVector.y += 9;
        offsetVector.z += 1.5f;
        transform.position = offsetVector;
    }
}
