
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Scale : MonoBehaviour
{
    private Vector3 _nextValue;
    private int _duration;

    private void Awake()
    {
        _duration = 4;
        _nextValue = new Vector3(3, 3, 3);
    }

    private void Start()
    {
        transform.DOScale(_nextValue, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
