using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _textMesh;

    private void Start()
    {
        _textMesh.DOText("Я заменил текст!", 2);
        _textMesh.DOText(" Я дополнил текст", 2).SetRelative().SetDelay(3);
        _textMesh.DOText("Ошибка: Текст был взломан!!!", 2, true, ScrambleMode.All).SetDelay(7);
    }
}
