using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRITEventsListeners
{
    [AddComponentMenu("")]
    public class HoverEnteredMessageListener : MessageListener
    {
        private void Start()
        {
            if (TryGetComponent(out XRBaseInteractable interactable))
            {
                interactable.hoverEntered.AddListener(args => EventBus.Trigger(XRIEventHooks.HoverEntered, gameObject, args));
            }
            else if (TryGetComponent(out XRBaseInteractor interactor))
            {
                interactor.hoverEntered.AddListener(args => EventBus.Trigger(XRIEventHooks.HoverEntered, gameObject, args));
            }
            else
            {
                Debug.LogWarning( "Unable to register for Hover Entered events. No XRBaseInteractable or XRBaseInteractor component is attached.");
            }
        }
    }
}