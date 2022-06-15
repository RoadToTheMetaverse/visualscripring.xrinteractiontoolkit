using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRIEventsListeners
{
    [AddComponentMenu("")]
    public class FirstSelectEnteredMessageListener: MessageListener
    {
        private void Start()
        {
            GetComponent<XRBaseInteractable>()?.firstSelectEntered
                ?.AddListener(args => EventBus.Trigger(XRIEventHooks.FirstSelectEntered, gameObject, args));
        }
    }
}