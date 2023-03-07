using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjects.Events
{
    public abstract class BaseEventListener<TParameter, TGameEvent, TUnityEvent> : MonoBehaviour, IEventListener<TParameter>
        where TGameEvent : BaseScriptableEvent<TParameter>
        where TUnityEvent : UnityEvent<TParameter>
    {
        [SerializeField] private TGameEvent gameEvent;
        [SerializeField] private TUnityEvent response;

        private void OnEnable() => gameEvent.RegisterListener(this);

        private void OnDisable() => gameEvent.UnregisterListener(this);

        public void OnEventRaised(TParameter value)
        {
            response?.Invoke(value);
        }
    }
}