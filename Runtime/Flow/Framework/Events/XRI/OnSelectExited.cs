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
    [UnitOrder(10)]
    
    public class OnSelectExited : SelectExitEventUnit
    {
        
        protected override string hookName => XRIEventHooks.SelectExited;
        
        public override Type MessageListenerType => typeof(SelectExitedMessageListener);
    }
}