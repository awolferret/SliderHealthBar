using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHealth : MonoBehaviour
{
    private static float _currentHealth;
    private float _changeAmount = 10f;

    public void DealDamage()
    {
        _currentHealth -= _changeAmount;
    }

    public void HealHealth()
    {
        _currentHealth += _changeAmount;
    }

    public static float ShowInfo()
    {
        return _currentHealth;
    }
}