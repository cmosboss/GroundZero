using UnityEngine;
using System.Collections;
using UnityEditor;

public class PlayStatistics : MonoBehaviour {
	public float Health = 100f;
	public float Mana = 100f;

    // Use this for initialization
    private Stats statScript;
    void Start() {
        statScript = GameObject.FindWithTag("GameController").gameObject.GetComponent<Stats>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Hit(float damage) {
        Health -= damage;
        if (Health <= 0) {
            statScript.roundEnd();
            statScript.SaveAllToDisk();
            //run gameover here.
            Application.LoadLevel("Main_Menu");

        }
    }
}
