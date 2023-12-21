using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
    private Vector3 _nextValue;

    private void Awake()
    {
        _nextValue = new Vector3(0, 360, 0);
    }

    private void Start()
    {
        transform.DORotate(_nextValue, 5, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
    }
}
