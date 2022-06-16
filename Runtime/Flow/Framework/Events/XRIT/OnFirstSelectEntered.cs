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
    [UnitOrder(4)]

    public class OnFirstSelectEntered: SelectEnterEventUnit
    {
        
        protected override string hookName => XRIEventHooks.FirstSelectEntered;
        
        public override Type MessageListenerType => typeof(FirstSelectEnteredMessageListener);
    }
}