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
    [UnitOrder(11)]
    
    public class OnTeleporting : TeleportingEventUnit
    {
        protected override string hookName => XRIEventHooks.Teleporting;
        
        public override Type MessageListenerType => typeof(TeleportingMessageListener);
    }
}