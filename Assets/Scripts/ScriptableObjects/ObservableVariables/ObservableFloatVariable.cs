using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "ObservableFloatVariable", menuName = "ScriptableVariable/ObservableFloatVariable")]
    public class ObservableFloatVariable : ObservableVariable<float>
    {
    }
}