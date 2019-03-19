using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    
    Animator animator;
    float verticalInput;
    float horizontalInput;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
    }
    void FixedUpdate()
    {
        animator.SetFloat("vAxis", verticalInput);
        animator.SetFloat("hAxis", horizontalInput);
        
        if (Input.GetKey(KeyCode.Z))
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