using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DynamicInput.Delegates;

namespace DynamicInput
{

    public class AdvancedInputSubscriber
    {
        private BooleanAction boolActs;
        private FloatAction floatActs;
        private Vector2Action vec2Acts;
        private Vector3Action vec3Acts;
        private Vector4Action vec4Acts;

        private InputActivatedAction subscriberActions;
        private ActionTest testActions;

        private string watchedAction = "";
        public PlayerInput watchedInput;
        
        public AdvancedInputSubscriber(PlayerInput playerInput)
        {
            watchedInput = playerInput;

            subscriberActions += evaluateInput;
            subscriberActions += isActivated;
            subscriberActions += tryEvaluateBoolInput;
            subscriberActions += tryEvaluateFloatInput;
            subscriberActions += tryEvaluateVector2Input;
            subscriberActions += tryEvaluateVector3Input;
            subscriberActions += tryEvaluateVector4Input;
        }

        public void setWatchedAction(string action)
        {
            if (watchedInput != null)
            {
                if (watchedAction == "")
                {
                    watchedInput.actions[watchedAction].performed += invokeSubscriberActions;
                }
                else
                {
                    watchedInput.actions[watchedAction].performed -= invokeSubscriberActions;

                    watchedAction = action;


                    watchedInput.actions[watchedAction].performed += invokeSubscriberActions;

                }
            }
        }

        public void invokeSubscriberActions(InputAction.CallbackContext context)
        {
            subscriberActions?.Invoke(context);
        }

        public void evaluateInput(InputAction.CallbackContext context)
        {
            //Debug code
            System.Type valueType = context.valueType;

            Debug.LogFormat($"Input type: {valueType} with value of {context.ReadValueAsObject()}");
        }

        public void isActivated(InputAction.CallbackContext context)
        {
            testActions?.Invoke();
        }

        public bool evaluatesAs(InputAction.CallbackContext context, System.Type asType)
        {
            System.Type valueType = context.valueType;

            var value = context.ReadValueAsObject();

            return (valueType.Equals(asType));
        }

        public void tryEvaluateBoolInput(InputAction.CallbackContext context)
        {
            if (evaluatesAs(context, (true).GetType()))
            {
                boolActs?.Invoke((bool)(context.ReadValueAsObject()));
            }
        }

        public void tryEvaluateFloatInput(InputAction.CallbackContext context)
        {
            if (evaluatesAs(context, (0.1f).GetType()))
            {
                floatActs?.Invoke((float)(context.ReadValueAsObject()));
            }
        }

        public void tryEvaluateVector2Input(InputAction.CallbackContext context)
        {
            if (evaluatesAs(context, (new Vector2()).GetType()))
            {
                vec2Acts?.Invoke((Vector2)(context.ReadValueAsObject()));
            }
        }

        public void tryEvaluateVector3Input(InputAction.CallbackContext context)
        {
            if (evaluatesAs(context, (new Vector3()).GetType()))
            {
                vec3Acts?.Invoke((Vector3)(context.ReadValueAsObject()));
            }
        }

        public void tryEvaluateVector4Input(InputAction.CallbackContext context)
        {
            if (evaluatesAs(context, (new Vector4()).GetType()))
            {
                vec4Acts?.Invoke((Vector4)(context.ReadValueAsObject()));
            }
        }

        public void addActionTest(ActionTest test)
        {
            if (testActions == null)
            {
                testActions = test;
            }
            else
            {
                testActions += test;
            }
        }

        public void removeActionTest(ActionTest test)
        {
            if (testActions != null)
            {
                testActions -= test;
            }
        }

        public void addBoolActs(BooleanAction acts)
        {
            if (boolActs == null)
            {
                boolActs = acts;
            }
            else
            {
                boolActs += acts;
            }
        }

        public void removeBoolActs(BooleanAction acts)
        {
            if (boolActs != null)
            {
                boolActs -= acts;
            }
        }

        public void addFloatActs(FloatAction acts)
        {
            if (floatActs == null)
            {
                floatActs = acts;
            }
            else
            {
                floatActs += acts;
            }
        }

        public void removeFloatActs(FloatAction acts)
        {
            if (floatActs != null)
            {
                floatActs -= acts;
            }
        }

        public void addVec2Acts(Vector2Action acts)
        {
            if (vec2Acts == null)
            {
                vec2Acts = acts;
            }
            else
            {
                vec2Acts += acts;
            }
        }

        public void removeVec2Acts(Vector2Action acts)
        {
            if (vec2Acts != null)
            {
                vec2Acts -= acts;
            }
        }

        public void addVec3Acts(Vector3Action acts)
        {
            if (vec3Acts == null)
            {
                vec3Acts = acts;
            }
            else
            {
                vec3Acts += acts;
            }
        }

        public void removeVec3Acts(Vector3Action acts)
        {
            if (vec3Acts != null)
            {
                vec3Acts -= acts;
            }
        }

        public void addVec4Acts(Vector4Action acts)
        {
            if (vec4Acts == null)
            {
                vec4Acts = acts;
            }
            else
            {
                vec4Acts += acts;
            }
        }

        public void removeVec4Acts(Vector4Action acts)
        {
            if (vec4Acts != null)
            {
                vec4Acts -= acts;
            }
        }
    }

}
