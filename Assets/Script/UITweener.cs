using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UITweener : MonoBehaviour
{
    [SerializeField]
    RectTransform _targetRect;
    [SerializeField]
    Image _image; 

    [SerializeField]
    Vector3 _targetPos;

    [SerializeField]
    float _duration;
    [SerializeField]
    KeyCode _triggercode;

    [SerializeField]
    Color _originColor, _targetColor;

    Tween _tween;

    [SerializeField]
    Ease _Ease = Ease.InFlash; 

    [SerializeField]
    bool _startWithTween = false; 
        
    // Start is called before the first frame update
    void Start()
    {
        if(_startWithTween)
            _tween = _targetRect.DOAnchorPos(new Vector3(), 0.1f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(_triggercode))
        {
            Debug.Log("Delet ´©¸§");
            // _tween = _targetRect.DOAnchorPos(_targetPos);
            StartMove();
            _image.DOColor(_targetColor, _duration).SetEase(_Ease);
        }
        else if (Input.GetKeyUp(_triggercode))
        {
            ReStartMove();
            Debug.Log("Delet ¶«");
            _image.DOColor(_originColor, _duration).SetEase(_Ease);
        }


    }

    public void ShakeIt()
    {
        if (_tween.IsPlaying())
        {
            _tween.Kill();
            _targetRect.DOAnchorPos(new Vector3(), 0.1f);
        }
        _tween = _targetRect.DOShakeAnchorPos(_duration);
    }

    public void StartMove()
    {
        _tween = _targetRect.DOAnchorPos(_targetPos, _duration).SetEase(_Ease);
    }

    public void ReStartMove()
    {
        _tween = _targetRect.DOAnchorPos(new Vector3(), _duration).SetEase(_Ease);
    }

}
