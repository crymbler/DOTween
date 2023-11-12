using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeParameters : MonoBehaviour
{
    private int _delayRate = 3;
    private int _loopCount = -1;

    private int _xStartPosition = 2;
    private int _yStartPosition = 2;
    private int _zStartPosition = 2;

    private int _xEndPosition = 1;
    private int _yEndPosition = 5;
    private int _zEndPosition = 0;

    private int _rotateValue = 360;

    private void Start()
    {
        transform.DOScale(new Vector3(_xStartPosition, _yStartPosition, _zStartPosition), _delayRate)
                 .SetLoops(_loopCount, LoopType.Yoyo)
                 .SetEase(Ease.Linear);
        transform.DOMove(new Vector3(_xEndPosition, _yEndPosition, _zEndPosition), _delayRate)
                 .SetLoops(_loopCount, LoopType.Yoyo)
                 .SetEase(Ease.Linear);
        transform.DORotate(new Vector3(_rotateValue, _rotateValue, 0), _delayRate, RotateMode.FastBeyond360)
                 .SetLoops(_loopCount, LoopType.Restart)
                 .SetEase(Ease.Linear);
    }
}
