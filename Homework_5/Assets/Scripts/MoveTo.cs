using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    private void Start()
    {
        transform.DOMove(new Vector3(-5, 5, 0), 3)
                 .SetLoops(-1, LoopType.Yoyo)
                 .SetEase(Ease.Linear);
    }
}
