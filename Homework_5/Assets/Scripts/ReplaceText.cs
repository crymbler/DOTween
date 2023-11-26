using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ReplaceText : MonoBehaviour
{
    [SerializeField] private Text _textMesh;

    private int _delay = 4;
    private int _delayRate = 3;

    private void Start()
    {
        _textMesh.DOText("Я заменил текст!", _delayRate);
        _textMesh.DOText(" Я дополнил текст", _delayRate).SetRelative().SetDelay(_delay);
        _textMesh.DOText("Ошибка: Текст был взломан!!!", _delayRate, true, ScrambleMode.All).SetDelay(_delay);
    }
}
