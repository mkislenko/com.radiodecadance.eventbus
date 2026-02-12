using UnityEngine;
using UnityEngine.Events;

namespace RadioDecadance.EventBus
{
    [CreateAssetMenu(fileName = "EventChannel", menuName = "Events/EventChannel")]
    public class EventChannel : ScriptableObject
    {
        public event UnityAction OnEventRaised;

        public void RaiseEvent()
        {
            OnEventRaised?.Invoke();
        }
    }

    public class EventChannel<T> : ScriptableObject
    {
        public event UnityAction<T> OnEventRaised;
        
        public void RaiseEvent(T data)
        {
            OnEventRaised?.Invoke(data);
        }
    }
}