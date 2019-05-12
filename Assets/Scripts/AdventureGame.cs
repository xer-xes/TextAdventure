using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI storyText;
    [SerializeField] State First_State;

    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = First_State;
        storyText.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageStates();
    }

    private void ManageStates()
    {
        var NextStates = state.GetNextStates();
        for (int i = 0; i < NextStates.Length;i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = NextStates[i];
            }
        }
        storyText.text = state.GetStateStory();
    }
}
