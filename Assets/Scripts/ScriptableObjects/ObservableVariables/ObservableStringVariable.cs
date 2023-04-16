using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "ObservableStringVariable", menuName = "ScriptableVariable/ObservableStringVariable")]
    public class ObservableStringVariable : ObservableVariable<string>
    {
    }
}