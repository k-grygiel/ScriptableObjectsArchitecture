using UnityEngine;

namespace ScriptableObjects.Events
{
    [CreateAssetMenu(fileName = "StringScriptableEvent", menuName = "ScriptableEvent/StringScriptableEvent")]
    public class StringScriptableEvent : BaseScriptableEvent<string>
    {
    }
}