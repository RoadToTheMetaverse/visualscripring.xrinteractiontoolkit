using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Flow.Framework.Events
{
    public abstract class HoverEnterEventUnit : GameObjectEventUnit<HoverEnterEventArgs>
    {
        
        /// <summary>
        /// The collider we hit.
        /// </summary>
        [DoNotSerialize]
        public ValueOutput interactor { get; private set; }
        
        /// <summary>
        /// The collider we hit.
        /// </summary>
        [DoNotSerialize]
        public ValueOutput interactable { get; private set; }
        
        
        protected override void Definition()
        {
            base.Definition();

            interactor = ValueOutput<Transform>(nameof(interactor));
            interactable = ValueOutput<Transform>(nameof(interactable));
            
        }

        protected override void AssignArguments(Unity.VisualScripting.Flow flow, HoverEnterEventArgs args)
        {
            flow.SetValue(interactor, args.interactorObject.transform);
            flow.SetValue(interactable, args.interactableObject.transform);
        }
        
    }
}