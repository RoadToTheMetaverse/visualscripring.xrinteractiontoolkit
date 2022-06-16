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
    [UnitOrder(9)]
    
    public class OnSelectEntered: SelectEnterEventUnit
    {
        
        protected override string hookName => XRIEventHooks.SelectEntered;
        
        public override Type MessageListenerType => typeof(SelectEnteredMessageListener);
    }
}