using ScriptableObjects;
using TMPro;
using UnityEngine;

public class TextHeatlhbar : MonoBehaviour
{
    [SerializeField] private IntVariable health;
    [SerializeField] private IntVariable maxHealth;

    private TextMeshProUGUI _healthText;

    private void Awake()
    {
        _healthText = GetComponent<TextMeshProUGUI>();
        UpdateHealthbar();
    }

    public void UpdateHealthbar()
    {
        _healthText.text = $"{health.RuntimeValue}/{maxHealth.RuntimeValue}";
    }
}