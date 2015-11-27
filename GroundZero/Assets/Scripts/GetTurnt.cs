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
        //use this for objects whos HIPS are oriented with Z axis going through them (dick to butt)
        //rb.AddRelativeForce(new Vector3(0,0,-1) * 3000);
        //use this for objects whos HIPs are oriented with Y axis going through them (dick to butt)
        rb.AddRelativeForce(new Vector3(0,-1,0) * 3000);


    }

}
