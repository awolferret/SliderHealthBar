using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Visual : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private float _scale = 0.1f;
    private Coroutine _coroutine;
    private float _changeShow = 10f;

    public void ShowHeal()
    {
        CheckCoroutine();
        _coroutine = StartCoroutine(ShowChange(_slider.value + _changeShow));
    }

    public void ShowDamage()
    {
        CheckCoroutine();
        _coroutine = StartCoroutine(ShowChange(_slider.value - _changeShow));
    }

    private void CheckCoroutine()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }
    }

    private IEnumerator ShowChange(float targetHealth)
    {
        float waitTime = 0.01f;
        var waitType = new WaitForSeconds(waitTime);

        while (_slider.value != targetHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetHealth, _scale);
            yield return waitType;
        }
    }
}