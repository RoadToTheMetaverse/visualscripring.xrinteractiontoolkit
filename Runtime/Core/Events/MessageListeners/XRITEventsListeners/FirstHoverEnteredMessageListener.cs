using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRITEventsListeners
{
    [AddComponentMenu("")]
    public sealed class FirstHoverEnteredMessageListener: MessageListener
    {
        private void Start()
        {
            GetComponent<XRBaseInteractable>()?.firstHoverEntered
                ?.AddListener( args => EventBus.Trigger(XRIEventHooks.FirstHoverEntered, gameObject, args));
        }
    }
}