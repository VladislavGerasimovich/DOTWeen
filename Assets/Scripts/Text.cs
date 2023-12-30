using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Text _text;

    private string _textOne;
    private string _textTwo;
    private string _textThree;
    private int _duration;

    private void Awake()
    {
        _duration = 3;
        _textOne = "замена текста";
        _textTwo = " добавление текста";
        _textThree = "замена текста с перебором";
    }

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText(_textOne, _duration));
        sequence.Append(_text.DOText(_textTwo, _duration).SetRelative());
        sequence.Append(_text.DOText(_textThree, _duration, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Incremental);
    }
}
