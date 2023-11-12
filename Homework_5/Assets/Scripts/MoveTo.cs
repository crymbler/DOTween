using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    private int _delay = 3;
    private int _loopCount = -1;

    private int _xPosition = -5;
    private int _yPosition = 5;
    private int _zPosition = 0;

    private void Start()
    {
        transform.DOMove(new Vector3(_xPosition, _yPosition, _zPosition), _delay)
                 .SetLoops(_loopCount, LoopType.Yoyo)
                 .SetEase(Ease.Linear);
    }
}
