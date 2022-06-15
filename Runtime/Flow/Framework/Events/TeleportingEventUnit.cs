using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Flow.Framework.Events
{
    public abstract class TeleportingEventUnit : GameObjectEventUnit<TeleportingEventArgs>
    {
        
        /// <summary>
        /// The Interactor associated with the interaction event.
        /// </summary>
        [DoNotSerialize]
        public ValueOutput interactor { get; private set; }
        
        /// <summary>
        /// The Interactable associated with the interaction event.
        /// </summary>
        [DoNotSerialize]
        public ValueOutput interactable { get; private set; }
        
        /// <summary>
        /// The position in world space of the Teleportation Destination.
        /// </summary>
        [DoNotSerialize]
        public ValueOutput destinationPosition { get; private set; }
        
        /// <summary>
        /// The rotation in world space of the Teleportation Destination. This is used primarily for matching world rotations directly.
        /// </summary>
        [DoNotSerialize]
        public ValueOutput destinationRotation { get; private set; }
        
        
        protected override void Definition()
        {
            base.Definition();

            interactor = ValueOutput<Transform>(nameof(interactor));
            interactable = ValueOutput<Transform>(nameof(interactable));
            destinationPosition = ValueOutput<Vector3>(nameof(destinationPosition));
            destinationRotation = ValueOutput<Quaternion>(nameof(destinationRotation));
            
        }

        protected override void AssignArguments(Unity.VisualScripting.Flow flow, TeleportingEventArgs args)
        {
            flow.SetValue(interactor, args.interactorObject.transform);
            flow.SetValue(interactable, args.interactableObject.transform);
            flow.SetValue(destinationPosition, args.teleportRequest.destinationPosition);
            flow.SetValue(destinationRotation, args.teleportRequest.destinationRotation);
        }
        
    }
}