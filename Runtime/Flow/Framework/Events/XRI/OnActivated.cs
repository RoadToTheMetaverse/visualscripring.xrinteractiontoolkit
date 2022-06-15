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
    [UnitOrder(1)]
    
    public class OnActivated: ActivateEventUnit
    {
        
        protected override string hookName => XRIEventHooks.Activated;
        
        public override Type MessageListenerType => typeof(ActivatedMessageListener);
    }
}