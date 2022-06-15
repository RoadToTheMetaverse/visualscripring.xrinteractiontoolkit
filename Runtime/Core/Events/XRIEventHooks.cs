namespace Core.Events
{
    public static class XRIEventHooks
    {
        // XRBaseInteractable
        public const string FirstHoverEntered = nameof(FirstHoverEntered);
        public const string LastHoverExited = nameof(LastHoverExited);
        public const string HoverEntered = nameof(HoverEntered);
        public const string HoverExited = nameof(HoverExited);
        public const string FirstSelectEntered = nameof(FirstSelectEntered);
        public const string LastSelectExited = nameof(LastSelectExited);
        public const string SelectEntered = nameof(SelectEntered);
        public const string SelectExited = nameof(SelectExited);
        public const string Activated = nameof(Activated);
        public const string Deactivated = nameof(Deactivated);
        
        // BaseTeleportationInteractable
        public const string Teleporting = nameof(Teleporting);
        

    }
}