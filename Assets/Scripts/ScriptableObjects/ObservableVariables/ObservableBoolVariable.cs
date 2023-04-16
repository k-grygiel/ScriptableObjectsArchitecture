using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "ObservableBoolVariable", menuName = "ScriptableVariable/ObservableBoolVariable")]
    public class ObservableBoolVariable : ObservableVariable<bool>
    {
    }
}