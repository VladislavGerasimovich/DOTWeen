using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
    [SerializeField] private Vector3 _position;

    private void Start()
    {
        transform.DOMove(_position, 10).SetLoops(-1, LoopType.Yoyo);
    }
}
