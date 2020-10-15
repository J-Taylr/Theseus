using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMove : MonoBehaviour
{

    public GameObject inputField;
    public string steps;
    public int stepsNum;
    public GameObject cube;

    public void PlayerMove()
    {

        steps = inputField.GetComponent<Text>().text;
        int stepsInt = Int32.Parse(steps);
        stepsNum = stepsInt;


        if (stepsNum == 1) //w moves player forward one space 
        {

            var currentPos = cube.transform.position;
            var newPosW = currentPos + Vector3.forward * 10;
            cube.transform.position = newPosW;
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