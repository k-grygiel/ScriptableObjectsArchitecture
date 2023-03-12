using ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace Examples
{
    public class SliderHealthbar : MonoBehaviour
    {
        [SerializeField] private IntVariable health;
        [SerializeField] private IntVariable maxHealth;

        private Slider _healthSlider;

        private void Awake()
        {
            _healthSlider= GetComponent<Slider>();
            UpdateHealthbar();
        }

        public void UpdateHealthbar()
        {
            _healthSlider.value = Mathf.Clamp01((float)health.RuntimeValue / maxHealth.RuntimeValue);
        }
    }
}