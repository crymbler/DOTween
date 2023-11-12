using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private int _delayRate = 3;
    private int _loopCount = -1;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _spriteRenderer.DOColor(Color.green, _delayRate)
                       .SetLoops(_loopCount, LoopType.Yoyo);
    }
}
