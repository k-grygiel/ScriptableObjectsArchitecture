using System;
using UnityEngine;

namespace ScriptableObjects
{
    public abstract class ObservableVariable<T> : ScriptableObject
    {
        public T InitialValue;

        private Action<T> _onValueChanged;
        private T _value;

        public T RuntimeValue
        {
            get => _value;
            set
            {
                _value = value;
                _onValueChanged?.Invoke(_value);
            }
        }

        private void OnEnable()
        {
            RuntimeValue = InitialValue;
        }

        public void SubscribeToValueChanged(Action<T> action)
        {
            _onValueChanged += action;
        }

        public void UnsubscribeFromValueChanged(Action<T> action)
        {
            _onValueChanged -= action;
        }
    }
}