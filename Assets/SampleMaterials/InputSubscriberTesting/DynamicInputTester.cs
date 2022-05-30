using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;

using DynamicInput.Delegates;
using DynamicInput;

public class DynamicInputTester : MonoBehaviour
{

    public PlayerInput watchedInput;
    public DynamicInputManager dynamicInputManager;

    // Start is called before the first frame update
    void Start()
    {
        if (watchedInput == null)
        {
            watchedInput = GetComponent<PlayerInput>();
        }

        dynamicInputManager = new DynamicInputManager(watchedInput);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
