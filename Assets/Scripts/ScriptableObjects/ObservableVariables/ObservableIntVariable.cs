using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "ObservableIntVariable", menuName = "ScriptableVariable/ObservableIntVariable")]
    public class ObservableIntVariable : ObservableVariable<int>
    {
    }
}