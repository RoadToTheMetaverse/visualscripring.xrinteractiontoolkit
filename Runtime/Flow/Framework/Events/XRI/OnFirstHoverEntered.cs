using System;
using Core.Events;
using Core.Events.MessageListeners.XRIEventsListeners;
using Unity.VisualScripting;
using UnityEngine.UI;

namespace Flow.Framework.Events.XRI
{
    
    /// <summary>
    /// Called when a user first hovers over an XRI Interactable.
    /// </summary>
    [UnitCategory("Events/XRI")]
    [TypeIcon(typeof(Button))]
    [UnitOrder(3)]
    
    public sealed class OnFirstHoverEntered : HoverEnterEventUnit
    {
        
        protected override string hookName => XRIEventHooks.FirstHoverEntered;
        
        public override Type MessageListenerType => typeof(FirstHoverEnteredMessageListener);
    }
}