using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ValueChanger : MonoBehaviour
{
    private Slider _slider;
    [SerializeField] private float _changeTime;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }


    public void ChangeValue(float Value) => _slider.DOValue(_slider.value + Value, _changeTime);
}
