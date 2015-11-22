using UnityEngine;
using System.Collections;

public class GetTurnt : MonoBehaviour {
    private Rigidbody rb;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	

    }
    public void getHit(Vector3 hitlocation) {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(new Vector3(0,0,-1) * 3000);
    }

}
