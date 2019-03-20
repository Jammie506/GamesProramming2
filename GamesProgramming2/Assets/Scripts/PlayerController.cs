using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    
    Animator animator;
    float verticalInput;
    float horizontalInput;
    float jumpInput;

    Rigidbody rB;

    void Start()
    {
        animator = GetComponent<Animator>();

        rB = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        jumpInput = Input.GetAxis("Jump");
    }
    void FixedUpdate()
    {
        animator.SetFloat("vAxis", verticalInput);
        animator.SetFloat("hAxis", horizontalInput);

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("Jump", true);
            Debug.Log("Jump");

        }
        else
        {
            animator.SetBool("Jump", false);
            Debug.Log("No Jump");
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("Run", true);
            Debug.Log("Run");

        }
        else
        {
            animator.SetBool("Run", false);
            Debug.Log("No Run");
        }
    }
}