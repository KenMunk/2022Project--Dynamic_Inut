using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DynamicInput.Delegates;

public class InputSubscriber : MonoBehaviour
{
    private BooleanAction   boolActs;
    private FloatAction     floatActs;
    private Vector2Action   vec2Acts;
    private Vector3Action   vec3Acts;
    private Vector4Action   vec4Acts;

    private bool xbool = true;
    private float xfloat = 1;
    private Vector2 xVector2 = new Vector2();
    private Vector3 xVector3 = new Vector3();
    private Vector4 xVector4 = new Vector4();

    // Start is called before the first frame update
    void Start()
    {
        PlayerInput testInput = GetComponent<PlayerInput>();

        testInput.actions["WASD"].performed += evaluateInput;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void evaluateInput(InputAction.CallbackContext context)
    {
        //Debug code
        System.Type valueType = context.valueType;

        Debug.LogFormat($"Input type: {valueType} with value of {context.ReadValueAsObject()}");

        var value = context.ReadValueAsObject();

        //These could probably be broken into individual functions which would allow for them all to be called in parallel since they're all type dependent.
        if (valueType.IsInstanceOfType(xbool))
        {
            Debug.Log("Bool detected");
            boolActs?.Invoke((bool)value);
            return;
        }
    }

    private void addBoolActs(BooleanAction acts)
    {
        if(boolActs == null)
        {
            boolActs = acts;
        }
        else
        {
            boolActs += acts;
        }
    }

    
}
