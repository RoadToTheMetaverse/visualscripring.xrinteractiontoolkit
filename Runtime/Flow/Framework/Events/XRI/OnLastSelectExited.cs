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
    [UnitOrder(8)]
    
    public class OnLastSelectExited: SelectExitEventUnit
    {
        
        protected override string hookName => XRIEventHooks.LastSelectExited;
        
        public override Type MessageListenerType => typeof(LastSelectExitedMessageListener);
    }
}