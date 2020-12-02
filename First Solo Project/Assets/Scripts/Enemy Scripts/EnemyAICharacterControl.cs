using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))]
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class EnemyAICharacterControl : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
        public EnemyThirdPersonCharacter character { get; private set; } // the character we are controlling
        public Vector3 target_position;

        //public EnemyAI

        private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
            character = GetComponent<EnemyThirdPersonCharacter>();

            

            agent.updateRotation = false;
	        agent.updatePosition = true;

            target_position = transform.position;//makes him stay in place at the start
            Debug.Log(target_position + "start" + transform.position);
        }

        

        private void Update()
        {
            //Debug.Log(agent.velocity);
            if (target_position != transform.position)
                Debug.Log(target_position + "asdf" + transform.position);

                Debug.Log(target_position + "pos");
                agent.SetDestination(target_position);

            if (agent.remainingDistance > agent.stoppingDistance)
                character.Move(agent.desiredVelocity, agent);
            else
                character.Move(Vector3.zero, agent);
        }


        public void SetTarget(Vector3 position)
        {
            this.target_position = position;
        }
    }
}
