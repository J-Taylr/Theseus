using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        if (Input.GetKeyDown(KeyCode.W)) //w moves player forward one space 
        {
            var currentPos = gameObject.transform.position;
            var newPosW = currentPos + Vector3.forward * 10;
            gameObject.transform.position = newPosW;
            currentPos = newPosW;
        }

        if (Input.GetKeyDown(KeyCode.A)) // a moves player left one space 
        {
            var currentPos = gameObject.transform.position;
            var newPosW = currentPos + Vector3.left * 10;
            gameObject.transform.position = newPosW;
            currentPos = newPosW;
        }

        if (Input.GetKeyDown(KeyCode.D)) // d moves player right one space 
        {
            var currentPos = gameObject.transform.position;
            var newPosW = currentPos + Vector3.right * 10;
            gameObject.transform.position = newPosW;
            currentPos = newPosW;
        }

        if (Input.GetKeyDown(KeyCode.S)) // s moves player back one space 
        {
            var currentPos = gameObject.transform.position;
            var newPosW = currentPos + Vector3.back * 10;
            gameObject.transform.position = newPosW;
            currentPos = newPosW;
        }
    }
}
