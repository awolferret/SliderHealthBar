using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private float _targetHealth;
    private float _healthScale = 0.1f;
    private Coroutine _coroutine;

    public void MoveSlider()
    {
        CheckCoroutine();
        _coroutine = StartCoroutine(MovingSlider(ChangeHealth.ShowInfo()));
    }

    private void CheckCoroutine()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }

    private IEnumerator MovingSlider(float targetHealth)
    {
        float waitTime = 0.01f;
        var waitType = new WaitForSeconds(waitTime);

        while (_slider.value != targetHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetHealth, _healthScale);
            yield return waitType;
        }
    }
}