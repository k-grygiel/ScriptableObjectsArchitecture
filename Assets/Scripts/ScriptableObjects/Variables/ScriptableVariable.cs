using System;
using UnityEngine;

namespace ScriptableObjects
{
    public class ScriptableVariable<T> : ScriptableObject, ISerializationCallbackReceiver
    {
        public T InitialValue;

        [NonSerialized]
        public T RuntimeValue;

        public void OnAfterDeserialize()
        {
            RuntimeValue = InitialValue;
        }

        public void OnBeforeSerialize()
        {
        }
    }
}