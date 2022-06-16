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
    [UnitOrder(1)]
    
    public class OnActivated: ActivateEventUnit
    {
        
        protected override string hookName => XRIEventHooks.Activated;
        
        public override Type MessageListenerType => typeof(ActivatedMessageListener);
    }
}