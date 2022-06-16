using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRITEventsListeners
{
    [AddComponentMenu("")]
    public class LastSelectExitedMessageListener : MessageListener
    {
        private void Start()
        {
            GetComponent<XRBaseInteractable>()?.lastSelectExited
                ?.AddListener(args => EventBus.Trigger(XRIEventHooks.LastSelectExited, gameObject, args));
        }
    }
}