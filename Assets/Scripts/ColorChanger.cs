using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer _renderer;
    private int _duration;

    private void Awake()
    {
        _duration = 2;
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _renderer.DOColor(Color.red, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
