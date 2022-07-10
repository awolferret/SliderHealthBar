using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float _health;
    private float _healthChange = 10f;

    public void Damage()
    {
        _health -= _healthChange;
    }

    public void Heal()
    {
        _health += _healthChange;
    }
}