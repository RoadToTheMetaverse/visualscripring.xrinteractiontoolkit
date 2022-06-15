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
    [UnitOrder(2)]

    public class OnDeactivated: DeactivateEventUnit
    {
        
        protected override string hookName => XRIEventHooks.Deactivated;
        
        public override Type MessageListenerType => typeof(DeactivatedMessageListener);
    }
}