using System;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public static event Action HealthChanged;

    public float _health { get; private set; }

    public void Heal(float healAmount)
    {
        _health += healAmount;
        HealthChanged?.Invoke();
    }

    public void Damage(float damageAmount)
    {
        _health -= damageAmount;
        HealthChanged?.Invoke();
    }
}