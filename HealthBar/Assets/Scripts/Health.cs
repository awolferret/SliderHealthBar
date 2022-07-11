using UnityEngine;

public class Health : MonoBehaviour
{
    private float _health;

    public void Heal(float healAmount)
    {
        _health += healAmount;
    }

    public void Damage(float damageAmount)
    {
        _health -= damageAmount;
    }

    public float ShowHealth()
    {
        return _health;
    }
}