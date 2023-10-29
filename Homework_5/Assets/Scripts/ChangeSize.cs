using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeSize : MonoBehaviour
{
    private void Start()
    {
        transform.DOScale(new Vector3(2,2,2), 3)
                 .SetLoops(-1, LoopType.Yoyo)
                 .SetEase(Ease.Linear);
    }
}
