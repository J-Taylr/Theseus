using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinotaurMovement : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent agent;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 positionOfPlayer = GameObject.Find("Player").transform.position;
        agent.SetDestination(positionOfPlayer);
        nearPlayer();


        
    }
    public void  nearPlayer()
    {
        if (agent.remainingDistance < 5)
        {
            string nearYou = "You can feel hes breath";
            print(nearYou);
        }

        
    }
}
