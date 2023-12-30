using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
    [SerializeField] private Vector3 _position;

    private int _duration;

    private void Awake()
    {
        _duration = 10;
    }

    private void Start()
    {
        transform.DOMove(_position, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
