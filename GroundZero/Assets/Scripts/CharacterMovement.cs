using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
    Animator animator;
    public float speed = 1.0f;
    public float rotationSpeed = 100.0F;
    private bool canMove = true;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }

    IEnumerator delayCanMove()
    {
        yield return new WaitForSeconds(0.15f);
        canMove = false;
        animator.SetBool("Heavy Attack", false);
        yield return new WaitForSeconds(0.75f);
        canMove = true;


    }
    // Update is called once per frame
    void Update () {
        if (canMove == true){
            if (Input.GetMouseButtonDown(0)){
                animator.SetBool("Heavy Attack", true);
                StartCoroutine(delayCanMove());
            }
            float translation = Input.GetAxis("Vertical") * speed;
            animator.SetFloat("Speed", translation);
            translation *= Time.deltaTime;
            transform.Translate(0, 0, translation);
        }
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        transform.Rotate(0, rotation, 0);

    }
}
