using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
    private int _delayRate = 3;
    private int _loopCount = -1;

    private int _rotateValue = 360;

    private void Start()
    {
        transform.DORotate(new Vector3(_rotateValue, _rotateValue, 0), _delayRate, RotateMode.FastBeyond360)
                 .SetLoops(_loopCount, LoopType.Restart)
                 .SetEase(Ease.Linear);
    }
}
