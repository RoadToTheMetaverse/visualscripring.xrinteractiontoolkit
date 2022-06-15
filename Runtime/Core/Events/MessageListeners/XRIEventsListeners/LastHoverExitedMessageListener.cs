using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRIEventsListeners
{
    [AddComponentMenu("")]
    public class LastHoverExitedMessageListener : MessageListener
    {
        private void Start()
        {
            GetComponent<XRBaseInteractable>()?.lastHoverExited
                ?.AddListener( args => EventBus.Trigger(XRIEventHooks.LastHoverExited, gameObject, args));
        }
    }
}