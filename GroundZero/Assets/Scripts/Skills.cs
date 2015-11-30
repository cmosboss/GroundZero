using UnityEngine;
using System.Collections;

public class Skills : MonoBehaviour {
    Animator animator;

    // Use this for initialization
    private Stats statScript;
    void Start() {
        statScript = GameObject.FindWithTag("GameController").gameObject.GetComponent<Stats>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Casting")) {
        } else {
            if (Input.GetMouseButtonDown(1)) {
                statScript.onCast();
                animator.SetBool("Casting", true);
                GameObject prefab = (GameObject)Resources.Load("Fireball");
                Transform SpellSpawn = GameObject.FindWithTag("SpellSpawn").transform;
                Instantiate(prefab, SpellSpawn.position, transform.rotation);
            } else {
                animator.SetBool("Casting", false);

            }
        }

    }
}
