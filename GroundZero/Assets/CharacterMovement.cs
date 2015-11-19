using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
    Animator animator;
    public float speed = 1.0f;
    public float rotationSpeed = 100.0F;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        float translation = Input.GetAxis("Vertical") * speed;
        animator.SetFloat("Speed", translation);
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        animator.SetFloat("Turning", rotation);
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}
