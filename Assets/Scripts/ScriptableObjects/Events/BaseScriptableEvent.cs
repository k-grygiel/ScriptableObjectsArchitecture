using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects.Events
{
    public abstract class BaseScriptableEvent<T> : ScriptableObject
    {
        private List<IEventListener<T>> listeners = new();

        public void RegisterListener(IEventListener<T> listener)
        {
            if (listeners.Contains(listener))
                return;

            listeners.Add(listener);
        }

        public void UnregisterListener(IEventListener<T> listener)
        {
            listeners.Remove(listener);
        }

        public void Raise(T value)
        {
            for (int i = listeners.Count; i >= 0; i--)
            {
                listeners[i].OnEventRaised(value);
            }
        }
    }

    public interface IEventListener<EventType>
    {
        public void OnEventRaised(EventType value);
    }
}