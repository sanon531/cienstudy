using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    Slider _healthBar, _steminaBar;
    [SerializeField]
    Text _time;


    public void SetHealth(float _arg)
    {
        _healthBar.value = _arg;
    }
    public void SetMaxHealth(float _arg)
    {
        _healthBar.maxValue = _arg;
    }

    public void SetStemina(float _arg)
    {
        _steminaBar.value = _arg;

    }
    public void SetMaxStemina(float _arg)
    {
        _steminaBar.maxValue = _arg;
    }

    public void SetTime(float _arg)
    {
        _arg = (float)Math.Round(_arg);
        _time.text = _arg.ToString();
    }
}
