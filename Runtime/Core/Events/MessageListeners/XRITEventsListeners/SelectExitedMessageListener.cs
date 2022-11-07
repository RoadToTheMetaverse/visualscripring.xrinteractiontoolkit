using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Core.Events.MessageListeners.XRITEventsListeners
{
    [AddComponentMenu("")]
    public class SelectExitedMessageListener : MessageListener
    {
        private void Start()
        {
            if (TryGetComponent(out XRBaseInteractable interactable))
            {
                interactable.selectExited.AddListener(args => EventBus.Trigger(XRIEventHooks.SelectExited, gameObject, args));
            }
            else if (TryGetComponent(out XRBaseInteractor interactor))
            {
                interactor.selectExited.AddListener(args => EventBus.Trigger(XRIEventHooks.SelectExited, gameObject, args));
            }
            else
            {
                Debug.LogWarning( "Unable to register for Select Exited events. No XRBaseInteractable or XRBaseInteractor component is attached.");
            }
        }
    }
}