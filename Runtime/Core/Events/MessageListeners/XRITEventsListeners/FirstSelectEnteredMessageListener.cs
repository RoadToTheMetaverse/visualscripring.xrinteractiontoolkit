using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRITEventsListeners
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