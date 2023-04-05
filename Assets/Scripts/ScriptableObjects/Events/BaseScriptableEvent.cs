using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects.Events
{
    public abstract class BaseScriptableEvent<T> : ScriptableObject
    {
        private List<IEventListener<T>> listeners = new();

#if UNITY_EDITOR
        public IReadOnlyList<IEventListener<T>> Listeners => listeners.AsReadOnly();
#endif

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
            for (int i = listeners.Count - 1; i >= 0; i--)
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