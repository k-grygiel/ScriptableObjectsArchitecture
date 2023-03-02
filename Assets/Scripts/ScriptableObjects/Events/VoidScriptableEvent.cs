using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "VoidScriptableEvent", menuName = "ScriptableEvent/VoidScriptableEvent")]
    public class VoidScriptableEvent : ScriptableObject
    {
        [SerializeField] private string description;

        private List<IVoidEventListener> listeners = new ();

        public void RegisterListener(IVoidEventListener listener)
        {
            if (listeners.Contains(listener))
                return;

            listeners.Add(listener);
        }

        public void UnregisterListener(IVoidEventListener listener)
        {
            listeners.Remove(listener);
        }

        public void Raise()
        {
            for (int i = listeners.Count; i >= 0; i--)
            {
                listeners[i].OnEventRaised();
            }
        }
    }

    public interface IVoidEventListener
    {
        public void OnEventRaised();
    }
}