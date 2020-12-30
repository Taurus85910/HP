using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ColorChanger : MonoBehaviour
{
    private Image _image;
    [SerializeField] private Slider _slider;
    private void Start()
    {
        _image = GetComponent<Image>();
    }

    public void Update()
    {
         _image.color = Color.Lerp(Color.red, Color.green, _slider.value / _slider.maxValue);       
    }
}
