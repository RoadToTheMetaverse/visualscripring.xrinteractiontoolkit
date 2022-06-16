using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRITEventsListeners
{
    [AddComponentMenu("")]
    public class DeactivatedMessageListener: MessageListener
    {
        private void Start()
        {
            GetComponent<XRBaseInteractable>()?.deactivated
                ?.AddListener(args => EventBus.Trigger(XRIEventHooks.Deactivated, gameObject, args));
        }
    }
}