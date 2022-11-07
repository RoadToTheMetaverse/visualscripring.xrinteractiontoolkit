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
            if (TryGetComponent(out XRBaseInteractable interactable))
            {
                interactable.hoverExited.AddListener(args => EventBus.Trigger(XRIEventHooks.HoverExited, gameObject, args));
            }
            else if (TryGetComponent(out XRBaseInteractor interactor))
            {
                interactor.hoverExited.AddListener(args => EventBus.Trigger(XRIEventHooks.HoverExited, gameObject, args));
            }
            else
            {
                Debug.LogWarning( "Unable to register for Hover Exited events. No XRBaseInteractable or XRBaseInteractor component is attached.");
            }
        }
    }
}