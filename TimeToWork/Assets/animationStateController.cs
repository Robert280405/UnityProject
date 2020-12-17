using UnityEngine;

public class animationStateController : MonoBehaviour
{

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

    }


    void Update()
    {
        bool isRunning = animator.GetBool("isRunning");
        bool isWalking = animator.GetBool("isWalking");
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        // if player is pressing w key
        if (!isWalking && forwardPressed)
        {
            //set the isWalking boolean true
            animator.SetBool("isWalking", true);
        }

        // if player is not pressing w key
        if (isWalking && !forwardPressed)
        {
            //set the isWalking boolean false
            animator.SetBool("isWalking", false);
        }

        //if player is walking and presses left shift
        if (!isRunning && (forwardPressed && runPressed))
        {
            //set isRunning boolen true
            animator.SetBool("isRunning", true);
        }

        //if player stops running or stops walking
        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunning", false);
        }
    }
}
