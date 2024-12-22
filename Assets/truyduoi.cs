using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class truyduoi : StateMachineBehaviour
{ 
    NavMeshAgent agent;
    Transform player;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    //
        agent=animator.GetComponent<NavMeshAgent>();
         player =GameObject.FindWithTag("Player").transform;    
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    //    
                agent.SetDestination(player.position);
           float distance =Vector3.Distance(animator.transform.position,player.position);
        if(distance<7)
        {
            animator.SetBool("istancong",true);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    //    
        agent.SetDestination(agent.transform.position);
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    //    // Implement code that processes and affects root motion
    }

    // OnStateIK is called right after Animator.OnAnimatorIK()
    override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    //    // Implement code that sets up animation IK (inverse kinematics)
    }
}
