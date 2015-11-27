using UnityEngine;
using System.Collections;

public class SpellProjectile : MonoBehaviour {
    public float speed = 5.0f;
    public float damage = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    void OnCollisionEnter(Collision collision) {
        //get the direction of impact, then get the position of the target, then make the decal spawn at the location of target + 2x offset. (so it looks like blood is coming out the back of them based on where you hit them)
        if (collision.gameObject.tag == "Enemy") {
            GameObject prefab = (GameObject)Resources.Load("Fireball_Hit");
            Vector3 groundedLocation = transform.position;
            groundedLocation.y = 0.1f;
            Instantiate(prefab, groundedLocation, transform.rotation);
            Instantiate(Resources.Load("BloodSplatter"), groundedLocation, Quaternion.Euler(0.0f, Random.Range(0.0f, 360.0f), 0.0f));
            collision.gameObject.GetComponent<EnemyStats>().Hit(damage);
        }
        Destroy(gameObject);
    }
}
