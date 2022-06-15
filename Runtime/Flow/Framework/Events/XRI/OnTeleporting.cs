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
    [UnitOrder(11)]
    
    public class OnTeleporting : TeleportingEventUnit
    {
        protected override string hookName => XRIEventHooks.Teleporting;
        
        public override Type MessageListenerType => typeof(TeleportingMessageListener);
    }
}