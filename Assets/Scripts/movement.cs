using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    public string steps;
    public GameObject inputField;
    public Vector3 position;

    public void Move()
    {
        steps = inputField.GetComponent<Text>().text;


    }
}