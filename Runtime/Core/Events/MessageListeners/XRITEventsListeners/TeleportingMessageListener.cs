using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRITEventsListeners
{
    [AddComponentMenu("")]
    public class TeleportingMessageListener : MessageListener
    {
        private void Start()
        {
            GetComponent<BaseTeleportationInteractable>()?.teleporting
                ?.AddListener(args => EventBus.Trigger(XRIEventHooks.Teleporting, gameObject, args));
        }
    }
}