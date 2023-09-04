using NaughtyAttributes;
using UnityEngine;

namespace NikosAssets.Helpers.ScriptableObjectWrappers
{
    public abstract class BaseSOW<T> : BaseNotesSO
    {
        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        protected T _value;

        public virtual T GetValue() => _value;

        public virtual void SetValue(T newVal) => _value = newVal;
    }
}
