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
        rb.AddRelativeForce(Vector3.back * 3000);
        // rb.AddRelativeForce(hitlocation * 1000);

    }

}
