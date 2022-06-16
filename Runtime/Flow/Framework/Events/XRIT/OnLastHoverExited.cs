using System;
using Core.Events;
using Core.Events.MessageListeners.XRITEventsListeners;
using Unity.VisualScripting;
using UnityEngine.UI;

namespace Flow.Framework.Events.XRIT
{
    
    /// <summary>
    /// Called when the last remaining hovering interactor end hovering.
    /// </summary>
    [UnitCategory("Events/XRIT")]
    [TypeIcon(typeof(Button))]
    [UnitOrder(7)]
    
    public class OnLastHoverExited : HoverExitEventUnit
    {
        protected override string hookName => XRIEventHooks.LastHoverExited;
        
        public override Type MessageListenerType => typeof(LastHoverExitedMessageListener);
    }
}