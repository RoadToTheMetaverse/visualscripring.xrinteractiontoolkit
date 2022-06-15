using System;
using Core.Events;
using Core.Events.MessageListeners.XRIEventsListeners;
using Unity.VisualScripting;
using UnityEngine.UI;

namespace Flow.Framework.Events.XRI
{

    /// <summary>
    /// ...
    /// </summary>
    [UnitCategory("Events/XRI")]
    [TypeIcon(typeof(Button))]
    [UnitOrder(6)]

    public class OnHoverExited: HoverExitEventUnit
    {
        
        protected override string hookName => XRIEventHooks.HoverExited;
        
        public override Type MessageListenerType => typeof(HoverExitedMessageListener);
    }
}