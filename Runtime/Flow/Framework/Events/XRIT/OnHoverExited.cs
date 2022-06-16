using System;
using Core.Events;
using Core.Events.MessageListeners.XRITEventsListeners;
using Unity.VisualScripting;
using UnityEngine.UI;

namespace Flow.Framework.Events.XRIT
{

    /// <summary>
    /// ...
    /// </summary>
    [UnitCategory("Events/XRIT")]
    [TypeIcon(typeof(Button))]
    [UnitOrder(6)]

    public class OnHoverExited: HoverExitEventUnit
    {
        
        protected override string hookName => XRIEventHooks.HoverExited;
        
        public override Type MessageListenerType => typeof(HoverExitedMessageListener);
    }
}