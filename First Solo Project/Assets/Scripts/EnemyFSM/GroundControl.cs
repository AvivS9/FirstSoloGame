using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GroundControl : StateMachineBehaviour
{
    GameObject NPC;
    private NavMeshAgent agent;
    private EnemyThirdPersonCharacter EnemyCharacter;
    //private Vector3 target_position;
    public GameObject target;// target to aim for

    bool move = false;
    public float radius = 10f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        target = GameObject.Find("FPSController");
        NPC = animator.gameObject;
        agent = NPC.GetComponent<NavMeshAgent>();
        EnemyCharacter = NPC.GetComponent<EnemyThirdPersonCharacter>();

        agent.updateRotation = true;
        agent.updatePosition = true;
        agent.isStopped = false;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Debug.Log(target.transform.position);
        if (target != null)
        {
            if (Vector3.Distance(target.transform.position, NPC.transform.position) < radius)
            {
                agent.isStopped = false;
                agent.SetDestination(target.transform.position);



                //Debug.Log(agent.desiredVelocity);
                if (agent.remainingDistance > agent.stoppingDistance)
                {
                    //Debug.Log(agent.remainingDistance);
                    EnemyCharacter.Move(agent.desiredVelocity, agent);
                }
                else
                {
                    //EnemyCharacter.Move(Vector3.zero, agent);

                    if (agent.velocity.magnitude == 0 && agent.remainingDistance > 0)
                    {
                        //Debug.Log("stop");
                        EnemyCharacter.attack();
                    }

                }
            }
            else
            {
                //Debug.Log("stop");
                agent.isStopped = true;
                EnemyCharacter.Move(agent.desiredVelocity, agent);
            }
        }


        
       
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

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
