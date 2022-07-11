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

    private void FixedUpdate()
    {
        _coroutine = StartCoroutine(ChangeHealth(_health.ShowHealth()));
    }

    private IEnumerator ChangeHealth(float targetHealth)
    {
        float waitTime = 0.01f;
        var waitType = new WaitForSeconds(waitTime);
        float _scale = 0.01f;

        while (_slider.value != targetHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetHealth, _scale);
            yield return waitType;
        }
    }
}