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

    bool minotaurMoving = false;
    // Update is called once per frame
    private void Start()
    {

        minotaurPosition = minotaur.transform.position;
       
    }


    private void Update()
    {

        if (minotaurMoving) 
        {            
                if (minotaurPosition.x - minotaur.transform.position.x < -40||minotaurPosition.z-minotaur.transform.position.z<-40||minotaurPosition.x-minotaur.transform.position.x<40||minotaurPosition.z-minotaur.transform.position.z<40)
                {
                    print(minotaur.transform.position);
                    minotaur.GetComponent<NavMeshAgent>().isStopped = true;
                    minotaurMoving = false;

                    print("minotaur last  position" + minotaurPosition.z);
                    

                }            
        }
    }


    public void MinotaurM()
    {
        
        minotaurMoving = true;
        minotaur.GetComponent<NavMeshAgent>().isStopped = false;
        Vector3 positionOfPlayer = GameObject.Find("Player").transform.position;

        
       
          //print("minotaur first position position"+minotaurPosition);

         

            agent.SetDestination(positionOfPlayer);

        

       

        minotaurPosition = minotaur.transform.position;
        //print("out if" + minotaurPosition);
        





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
