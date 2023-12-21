using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;

    private string _textOne;
    private string _textTwo;
    private string _textThree;

    private void Awake()
    {
        _textOne = "������ ������";
        _textTwo = " ���������� ������";
        _textThree = "������ ������ � ���������";
    }

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText(_textOne, 3));
        sequence.Append(_text.DOText(_textTwo, 3).SetRelative());
        sequence.Append(_text.DOText(_textThree, 3, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Incremental);
    }
}
