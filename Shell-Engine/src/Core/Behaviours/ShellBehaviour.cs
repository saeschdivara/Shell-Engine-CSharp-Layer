namespace Shell.Core.Behaviours
{
    public abstract class ShellBehaviour
    {
        protected GameObject gameObject;
        
        public virtual void OnCreate() {}
        public virtual void OnUpdate() {}
        public virtual void OnDestroy() {}
    }
}