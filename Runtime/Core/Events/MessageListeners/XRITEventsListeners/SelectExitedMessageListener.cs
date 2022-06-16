using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRITEventsListeners
{
    [AddComponentMenu("")]
    public class SelectExitedMessageListener : MessageListener
    {
        private void Start()
        {
            GetComponent<XRBaseInteractable>()?.selectExited
                ?.AddListener(args => EventBus.Trigger(XRIEventHooks.SelectExited, gameObject, args));
        }
    }
}