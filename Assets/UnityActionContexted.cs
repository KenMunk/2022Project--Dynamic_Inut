using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace DynamicInput
{
    namespace Delegates{
        public delegate void InputActivatedAction(InputAction.CallbackContext context);

        public delegate void BooleanAction(bool context);

        public delegate void FloatAction(float context);

        public delegate void Vector2Action(Vector2 context);

        public delegate void Vector3Action(Vector3 context);

        public delegate void Vector4Action(Vector4 context);
    }
}
