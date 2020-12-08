using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AttackFSM : StateMachineBehaviour
{
    GameObject NPC;
    private NavMeshAgent agent;
    private EnemyThirdPersonCharacter EnemyCharacter;
    private GameObject target;// target to aim for

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        target = GameObject.Find("Player");
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
        if (target != null)
        {
            if (Vector3.Distance(target.transform.position, NPC.transform.position) > agent.stoppingDistance)
            {
                //Debug.Log("stop attacking");
                EnemyCharacter.stopAttack();
            }
            
        }
    }

}
