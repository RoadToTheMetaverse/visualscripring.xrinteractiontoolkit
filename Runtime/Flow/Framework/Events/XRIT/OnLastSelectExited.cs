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
    [UnitOrder(8)]
    
    public class OnLastSelectExited: SelectExitEventUnit
    {
        
        protected override string hookName => XRIEventHooks.LastSelectExited;
        
        public override Type MessageListenerType => typeof(LastSelectExitedMessageListener);
    }
}