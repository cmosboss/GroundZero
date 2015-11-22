using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	Animator animator;
	public Transform target;
	public float speed = 2.5f;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		target = GameObject.FindWithTag("Player").transform;
	}
	void Update() {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position, step);
		animator.SetFloat("Speed", 1);
		Vector3 targetDir = target.position - transform.position;
		Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
		transform.rotation = Quaternion.LookRotation(newDir);
	}

}
