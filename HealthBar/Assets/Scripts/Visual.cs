using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Health))]

public class Visual : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private Health _health;
    private Coroutine _coroutine;

    private void Start()
    {
        _health = GetComponent<Health>();
    }

    private void OnEnable()
    {
        Health.HealthChanged += ShowChange;
    }

    private void OnDisable()
    {
        Health.HealthChanged -= ShowChange;
    }

    private void ShowChange()
    {
        StopCoroutine();
        _coroutine = StartCoroutine(ChangeHealth(_health._health));
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
        float _scale = 0.1f;
        var waitType = new WaitForSeconds(waitTime);

        while (_slider.value != targetHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetHealth, _scale);
            yield return waitType;
        }
    }
}