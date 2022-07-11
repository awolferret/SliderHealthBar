using System.Collections;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float _health;
    private float _targetHealth;
    private float _scale = 0.1f;
    private Coroutine _coroutine;

    public void Heal(float healAmount)
    {
        _targetHealth = _health + healAmount;
        StopCoroutine();
        _coroutine = StartCoroutine(ChangeHealth(_targetHealth));
    }

    public void Damage(float damageAmount)
    {
        _targetHealth = _health - damageAmount;
        StopCoroutine();
        _coroutine = StartCoroutine(ChangeHealth(_targetHealth));
    }

    public float ShowHealth()
    {
        return _health;
    }

    private void StopCoroutine()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }

    private IEnumerator ChangeHealth(float targetHealth)
    {
        float waitTime = 0.01f;
        var waitType = new WaitForSeconds(waitTime);

        while (_health != targetHealth)
        {
            _health = Mathf.MoveTowards(_health, targetHealth, _scale);
            yield return waitType;
        }
    }
}