using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMove : MonoBehaviour
{

    public GameObject inputField;
    public string steps;
    public int stepsNum;

    public int getSteps()
    {

        steps = inputField.GetComponent<Text>().text;
        int stepsInt = Int32.Parse(steps);
        return stepsInt;


    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        TextToMove move = new TextToMove();
        stepsNum = getSteps();

        if (stepsNum != 0) //w moves player forward one space 
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