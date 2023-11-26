using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LoopSize : MonoBehaviour
{
    private int _delay = 2;
    private int _loopCount = -1;

    private int _xPosition = 2;
    private int _yPosition = 2;
    private int _zPosition = 2;

    private void Start()
    {
        transform.DOScale(new Vector3(_xPosition, _yPosition, _zPosition), _delay)
                 .SetLoops(_loopCount, LoopType.Yoyo)
                 .SetEase(Ease.Linear);
    }
}
