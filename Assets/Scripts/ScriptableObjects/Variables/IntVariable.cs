using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "IntVariable", menuName = "ScriptableVariable/IntVariable")]
    public class IntVariable : ScriptableVariable<int>
    {
    }
}