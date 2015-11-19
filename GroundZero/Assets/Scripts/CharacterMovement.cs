﻿using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
    Animator animator;
    public float speed = 1.0f;
    private float movementSpeed = 0.0f;
    public float rotationSpeed = 100.0F;
    
    // Use this for initialization
    void Start () {
        movementSpeed = speed;
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            animator.SetBool("Heavy Attack", true);
        }
        else {
            animator.SetBool("Heavy Attack", false);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack Heavy")){
            movementSpeed = speed * 0.6f;
        }
        else{
            movementSpeed = speed;
        }
        //move
        float translation = Input.GetAxis("Vertical") * movementSpeed;
        animator.SetFloat("Speed", translation);
        translation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        //turn
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }
}
