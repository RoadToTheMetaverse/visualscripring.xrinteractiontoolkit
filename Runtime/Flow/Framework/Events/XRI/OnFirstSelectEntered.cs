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
    [UnitOrder(4)]

    public class OnFirstSelectEntered: SelectEnterEventUnit
    {
        
        protected override string hookName => XRIEventHooks.FirstSelectEntered;
        
        public override Type MessageListenerType => typeof(FirstSelectEnteredMessageListener);
    }
}