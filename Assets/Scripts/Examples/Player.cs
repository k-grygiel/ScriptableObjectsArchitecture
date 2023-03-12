using ScriptableObjects;
using UnityEngine;

namespace Examples
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private IntVariable playerHealth;
        [SerializeField] private IntVariable playerMaxHealth;
        [SerializeField] private VoidScriptableEvent playerHealthChanged;

        private void Awake()
        {
            playerHealth.RuntimeValue = playerMaxHealth.RuntimeValue;
        }

        public void DealDamage(int damage)
        {
            playerHealth.RuntimeValue = Mathf.Clamp(playerHealth.RuntimeValue - damage, 0, playerMaxHealth.RuntimeValue);
            playerHealthChanged.Raise();
        }
    }
}