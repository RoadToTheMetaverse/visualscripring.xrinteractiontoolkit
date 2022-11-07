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
            if (TryGetComponent(out XRBaseInteractable interactable))
            {
                interactable.selectEntered.AddListener(args => EventBus.Trigger(XRIEventHooks.SelectEntered, gameObject, args));
            }
            else if (TryGetComponent(out XRBaseInteractor interactor))
            {
                interactor.selectEntered.AddListener(args => EventBus.Trigger(XRIEventHooks.SelectEntered, gameObject, args));
            }
            else
            {
                Debug.LogWarning( "Unable to register for Select Entered events. No XRBaseInteractable or XRBaseInteractor component is attached.");
            }
        }
    }
}