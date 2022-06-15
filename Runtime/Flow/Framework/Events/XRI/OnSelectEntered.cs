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
    [UnitOrder(9)]
    
    public class OnSelectEntered: SelectEnterEventUnit
    {
        
        protected override string hookName => XRIEventHooks.SelectEntered;
        
        public override Type MessageListenerType => typeof(SelectEnteredMessageListener);
    }
}