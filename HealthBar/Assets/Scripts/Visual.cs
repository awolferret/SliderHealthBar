using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Health))]

public class Visual : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private Health _health;

    private void Start()
    {
        _health = GetComponent<Health>();
    }

    private void Update()
    {
        _slider.value = _health.ShowHealth();
    }
}