using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour {
    public float health = 100;
    public Vector3 hitlocation;
    private bool live = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (live == false) {
            Destroy(gameObject);
            GameObject gameController = GameObject.FindWithTag("GameController");
            gameController.GetComponent<WaveSystem>().CheckStage();
        }
	}
    public void Hit(float damage) {
        health -= damage;
        if (live == true){
            if (health <= 0) {
                live = false;
                GameObject prefab = (GameObject)Resources.Load("EnemyRagdoll");
                GameObject instance = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
                instance.transform.Find("Hips").GetComponent<GetTurnt>().getHit(hitlocation);
            } else {
                Vector3 head = transform.position;
                head.y = 1;
                GameObject prefab = (GameObject)Resources.Load("BloodSpray");
                Instantiate(prefab, head, Random.rotation);
            }
        }
    }
}
