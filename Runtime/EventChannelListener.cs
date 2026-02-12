using UnityEngine;
using UnityEngine.Events;

namespace RadioDecadance.EventBus
{
    public class EventChannelListener : MonoBehaviour
    {
        [SerializeField] private EventChannel eventChannel;
        [SerializeField] private UnityEvent response;

        private void OnEnable()
        {
            if (eventChannel != null)
            {
                eventChannel.OnEventRaised += HandleEventRaised;
            }
        }

        private void OnDisable()
        {
            if (eventChannel != null)
            {
                eventChannel.OnEventRaised -= HandleEventRaised;
            }
        }

        private void HandleEventRaised()
        {
            response?.Invoke();
        }
    }
}