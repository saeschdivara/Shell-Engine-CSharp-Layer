

using System;
using System.Runtime.CompilerServices;

namespace Shell.Core
{
    public class GameObject
    {
        private long _internalId;

        public GameObject(long internalId)
        {
            _internalId = internalId;
        }

        public T GetComponent<T>() where T : new()
        {
            var type = typeof(T);
            return (T) InternalGetComponent(type.Namespace, type.Name);
        }

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern Object InternalGetComponent(string clsNamespace, string cls);
    }
}