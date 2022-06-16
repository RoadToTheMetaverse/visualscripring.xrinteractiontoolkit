using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRITEventsListeners
{
    [AddComponentMenu("")]
    public class ActivatedMessageListener : MessageListener
    {
        private void Start()
        {
            GetComponent<XRBaseInteractable>()?.activated
                ?.AddListener(args => EventBus.Trigger(XRIEventHooks.Activated, gameObject, args));
        }
    }
}