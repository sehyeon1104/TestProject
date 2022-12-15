using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class CharacterByNavMesh : MonoBehaviour
{
    CharacterController characterController;
    NavMeshAgent agent;

    public LayerMask layerGround;

    bool flagOnGrounded = true;
    void Start()
    {
        characterController = GetComponent<CharacterController>();

        agent = GetComponent<NavMeshAgent>();
        agent.updatePosition = false;
        agent.updateRotation = true;
    }

    void Update()
    {
        RaycastHit hits;
        flagOnGrounded = characterController.isGrounded;

        if(Input.GetMouseButton(0))
        {
           if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hits, layerGround))
            {
                agent.SetDestination(hits.point);
            }
        }
        if(agent.remainingDistance>agent.stoppingDistance)
        {
            characterController.Move(agent.velocity * Time.deltaTime);
        }
        else
        {
            characterController.Move(Vector3.zero);
        }
    }

}
