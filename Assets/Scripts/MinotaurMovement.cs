using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinotaurMovement : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent agent;
    public GameObject minotaur;
    public Vector3 minotaurPosition;


    // Update is called once per frame
    private void Start()
    {

        minotaurPosition = minotaur.transform.position;
       
    }
    public void MinotaurM()
    {
        bool x;
        minotaur.GetComponent<NavMeshAgent>().isStopped = false;
        Vector3 positionOfPlayer = GameObject.Find("Player").transform.position;

        
       
          print("minotaur first position position"+minotaurPosition);

         

            agent.SetDestination(positionOfPlayer);
       
       

            if (minotaurPosition.x - minotaur.transform.position.x < -4)
            {
                print(minotaur.transform.position);
                minotaur.GetComponent<NavMeshAgent>().isStopped = true;

                print("minotaur last  position" + minotaurPosition);
                x = false;

            }
         

       

        minotaurPosition = minotaur.transform.position;
        print("out if" + minotaurPosition);
        





    }
    public void nearPlayer()
    {
        if (agent.remainingDistance < 5)
        {
            string nearYou = "You can feel hes breath";
            print(nearYou);
        }


    }

}
