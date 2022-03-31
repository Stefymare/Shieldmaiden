using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolScript : StateMachineBehaviour
{
    //[SerializeField] float RotSpeed = 10;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //animator.transform.Rotate(Vector3.up, RotSpeed * Time.deltaTime);

        if (SeePlayer(animator))
        {
            //spotted! , transition to follow state
            animator.SetInteger("State", 1);
        }

    }

    bool SeePlayer(Animator animator)
    {
        RaycastHit hit; //this variable stores what it hits bcs it's raycast

        if (Physics.Raycast(animator.transform.position, animator.transform.forward, out hit, 15))
        {
            //something was hit
            if (hit.transform.gameObject.CompareTag("Player"))
            {
                return true;
            };
        }

        return false;
    }
    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
