using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 5;
    
    private int _currentHealth;

    // Any UI or system can listen to these
    public event Action<int, int> OnHealthChanged; // (currentHealth, maxHealth)
    public event Action OnDeath;

    private void Start()
    {
        _currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        _currentHealth -= amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, maxHealth);
        
        OnHealthChanged?.Invoke(_currentHealth, maxHealth);
        
        if (_currentHealth <= 0)
        {
            OnDeath?.Invoke();
        }
    }

    public void Heal(int amount)
    {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, maxHealth);
        
        OnHealthChanged?.Invoke(_currentHealth, maxHealth);
    }

    // Handy getters in case something needs to read health directly
    public int GetCurrentHealth() => _currentHealth;
    public int GetMaxHealth() => maxHealth;
}
