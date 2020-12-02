using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    private NavMeshAgent agent;
    private EnemyThirdPersonCharacter character;
    //private Vector3 target_position;
    public Transform target;// target to aim for

    bool move = false;
    private float radius = 10f;




    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        character = GetComponent<EnemyThirdPersonCharacter>();

        //target_position = transform.position;//makes him stay in place at the start
        //Debug.Log(target_position + "start" + transform.position);

        agent.updateRotation = true;
        agent.updatePosition = true;
        agent.isStopped = false;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (target != null)
        {
            if (Vector3.Distance(target.position, transform.position) < radius)
            {
                agent.isStopped = false;
                agent.SetDestination(target.position);
            }
            else
            {
                agent.isStopped = true;
            }
        }



        //Debug.Log(agent.desiredVelocity);
        if (agent.remainingDistance > agent.stoppingDistance)
        {
            //Debug.Log(agent.remainingDistance);
            character.Move(agent.desiredVelocity, agent);
        }  
        else
        {
            character.Move(Vector3.zero, agent);
            
            if (agent.velocity.magnitude == 0) 
                character.attack();
        }
            

        /*
        if (move == true)
        {
            Debug.Log("moving to " + target_position);
            agent.SetDestination(target_position);


            if (agent.remainingDistance <= agent.stoppingDistance)
            {

                stopMoving();
                character.Move(Vector3.zero, agent);
            }
        }*/
       /* if (agent.remainingDistance > agent.stoppingDistance && move == true)
        {
            
            character.Move(agent.desiredVelocity, agent);
        }*/

        //Debug.Log("remain " + agent.remainingDistance + "stop " + agent.stoppingDistance);


    }

    /*public void SetTarget(Vector3 position)
    {
        this.target_position = position;
        move = true;
        agent.isStopped = false;

    }

    public void stopMoving()
    {
        move = false;
        agent.isStopped = true;
    }*/
}
