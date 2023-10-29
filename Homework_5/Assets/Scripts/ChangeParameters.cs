using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeParameters : MonoBehaviour
{
    private void Start()
    {
        transform.DOScale(new Vector3(2, 2, 2), 3)
                 .SetLoops(-1, LoopType.Yoyo)
                 .SetEase(Ease.Linear);
        transform.DOMove(new Vector3(1, 5, 0), 3)
                 .SetLoops(-1, LoopType.Yoyo)
                 .SetEase(Ease.Linear);
        transform.DORotate(new Vector3(360, 360, 0), 3, RotateMode.FastBeyond360)
                 .SetLoops(-1, LoopType.Restart)
                 .SetEase(Ease.Linear);
    }
}
