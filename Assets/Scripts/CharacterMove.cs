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
    public string direction;
    public string north = "north";
    public string south = "south";
    public string east = "east";
    public string west = "west";



    public void PlayerMove()
    {


        steps = inputField.GetComponent<Text>().text;
        string[] words = steps.Split(' ');
        int stepsInt = Int32.Parse(words[0]);
        direction = words[1];
        stepsNum = stepsInt;



        if (direction.Equals(north, StringComparison.OrdinalIgnoreCase)) //Moves to north
        {

            var currentPos = cube.transform.position;
            var newPosW = currentPos + Vector3.forward * 10 * stepsNum;
            cube.transform.position = newPosW;
            currentPos = newPosW;


        }

        if (direction.Equals(west, StringComparison.OrdinalIgnoreCase)) // a moves player left one space 
        {
            var currentPos = cube.transform.position;
            var newPosW = currentPos + Vector3.left * 10 * stepsNum;
           cube.transform.position = newPosW;
            currentPos = newPosW;
        }

        if (direction.Equals(east, StringComparison.OrdinalIgnoreCase))
        {
            var currentPos = cube.transform.position;
            var newPosW = currentPos + Vector3.right * 10 * stepsNum;
            cube.transform.position = newPosW;
            currentPos = newPosW;
        }

        if (direction.Equals(south, StringComparison.OrdinalIgnoreCase)) // s moves player back one space 
        {
            var currentPos = cube.transform.position;
            var newPosW = currentPos + Vector3.back * 10 * stepsNum;
           cube.transform.position = newPosW;
            currentPos = newPosW;
            print("im here");
        }
    }



}
