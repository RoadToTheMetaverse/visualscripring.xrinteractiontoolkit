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
    [UnitOrder(10)]
    
    public class OnSelectExited : SelectExitEventUnit
    {
        
        protected override string hookName => XRIEventHooks.SelectExited;
        
        public override Type MessageListenerType => typeof(SelectExitedMessageListener);
    }
}