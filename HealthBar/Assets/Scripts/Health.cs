using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private UnityEvent _healthChanged;

    private float _health;

    public void Heal(float healAmount)
    {
        _health += healAmount;
        _healthChanged.Invoke();
    }

    public void Damage(float damageAmount)
    {
        _health -= damageAmount;
        _healthChanged.Invoke();
    }

    public float ShowHealth()
    {
        return _health;
    }
}