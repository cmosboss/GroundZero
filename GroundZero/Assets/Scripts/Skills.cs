using UnityEngine;
using System.Collections;

public class Skills : MonoBehaviour {
    Animator animator;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            print("Spell!");
            animator.SetBool("Casting", true);
        } else {
            animator.SetBool("Casting", false);
        
        }
    }
}
