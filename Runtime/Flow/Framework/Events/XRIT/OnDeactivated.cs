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
    [UnitOrder(2)]

    public class OnDeactivated: DeactivateEventUnit
    {
        
        protected override string hookName => XRIEventHooks.Deactivated;
        
        public override Type MessageListenerType => typeof(DeactivatedMessageListener);
    }
}