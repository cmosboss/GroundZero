using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour {
    public float health = 100;
    public Vector3 hitlocation;
    private bool live = true;
    public float damage = 10;
    // Use this for initialization
    private Stats statScript;
    void Start() {
        statScript = GameObject.FindWithTag("GameController").gameObject.GetComponent<Stats>();

    }
	
	// Update is called once per frame
	void Update () {
        if (live == false) {
            statScript.onKill();
            Destroy(gameObject);
            GameObject gameController = GameObject.FindWithTag("GameController");
            gameController.GetComponent<WaveSystem>().CheckStage();
        }
	}
    void OnCollisionEnter(Collision collision) {
        //get the direction of impact, then get the position of the target, then make the decal spawn at the location of target + 2x offset. (so it looks like blood is coming out the back of them based on where you hit them)
        if (collision.gameObject.tag == "Player") {
                collision.gameObject.GetComponent<PlayStatistics>().Hit(damage);
        }

    }
    public void Hit(float damage) {
        health -= damage;
        if (live == true){
            if (health <= 0) {
                live = false;
                GameObject prefab = (GameObject)Resources.Load("EnemyBlobRagdoll");
                GameObject instance = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
                instance.transform.Find("hips").GetComponent<GetTurnt>().getHit(hitlocation);
            } else {
                Vector3 head = transform.position;
                head.y = 1;
                GameObject prefab = (GameObject)Resources.Load("BloodSpray");
                Instantiate(prefab, head, Random.rotation);
            }
        }
    }
}
