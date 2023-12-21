
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Scale : MonoBehaviour
{
    private Vector3 _nextValue;

    private void Awake()
    {
        _nextValue = new Vector3(3, 3, 3);
    }

    private void Start()
    {
        transform.DOScale(_nextValue, 4).SetLoops(-1, LoopType.Yoyo);
    }
}
