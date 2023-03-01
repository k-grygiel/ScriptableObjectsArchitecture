using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "StringVariable", menuName = "ScriptableVariable/StringVariable")]
    public class StringVariable : ScriptableVariable<string>
    {
    }
}