using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRITEventsListeners
{
    [AddComponentMenu("")]
    public class HoverExitedMessageListener: MessageListener
    {
        private void Start()
        {
            GetComponent<XRBaseInteractable>()?.hoverExited
                ?.AddListener(args => EventBus.Trigger(XRIEventHooks.HoverExited, gameObject, args));
        }
    }
}