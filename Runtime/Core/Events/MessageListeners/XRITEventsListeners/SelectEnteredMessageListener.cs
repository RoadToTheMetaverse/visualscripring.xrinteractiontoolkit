using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRITEventsListeners
{
    [AddComponentMenu("")]
    public class SelectEnteredMessageListener : MessageListener
    {
        private void Start()
        {
            GetComponent<XRBaseInteractable>()?.selectEntered
                ?.AddListener(args => EventBus.Trigger(XRIEventHooks.SelectEntered, gameObject, args));
        }
    }
}