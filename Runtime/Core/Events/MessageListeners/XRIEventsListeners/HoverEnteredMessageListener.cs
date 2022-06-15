using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRIEventsListeners
{
    [AddComponentMenu("")]
    public class HoverEnteredMessageListener : MessageListener
    {
        private void Start()
        {
            GetComponent<XRBaseInteractable>()?.hoverEntered
                ?.AddListener(args => EventBus.Trigger(XRIEventHooks.HoverEntered, gameObject, args));
        }
    }
}