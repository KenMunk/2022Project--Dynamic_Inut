using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;

using DynamicInput.Delegates;

namespace DynamicInput
{
    public class DynamicInputManager
    {
        public PlayerInput watchedInput;
        public List<AdvancedInputSubscriber> subscribers;

        public DynamicInputManager(PlayerInput playerInput)
        {
            watchedInput = playerInput;
            subscribers = new List<AdvancedInputSubscriber>();

            InputAction[] actions = watchedInput.currentActionMap.actions.ToArray();

            string actionNames = "";

            for(int i = 0; i<actions.Length; i++)
            {
                actionNames += actions[i].name+", ";
            }

            Debug.LogFormat($"Input detected with actions of following\n{actionNames}");
        }
    }
}
