using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversation : MonoBehaviour
{
    private int bestChoice = 1;
    private int goodChoice = 2;
    private int badChoice = 3;

    private Dictionary<int, KeyCode> choiceKeyMap;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the dictionary to map choices to KeyCodes
        choiceKeyMap = new Dictionary<int, KeyCode>
        {
            { bestChoice, KeyCode.Alpha1 },
            { goodChoice, KeyCode.Alpha2 },
            { badChoice, KeyCode.Alpha3 }
        };
    }

    // Update is called once per frame
    void Update()
    {
        // Check for key presses using the mapped keys
        if (Input.GetKeyDown(choiceKeyMap[bestChoice]))
        {
            Debug.Log("Best choice answered!");
        }
        else if (Input.GetKeyDown(choiceKeyMap[goodChoice]))
        {
            Debug.Log("Good choice answered!");
        }
        else if (Input.GetKeyDown(choiceKeyMap[badChoice]))
        {
            Debug.Log("Bad choice answered!");
        }
    }
}