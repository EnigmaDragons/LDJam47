﻿
using System.Collections;
using DG.Tweening;
using UnityEngine;

public class CreditLogoPresenter : MonoBehaviour
{
    [SerializeField] private FloatReference delayBeforeFlyAway = new FloatReference(3f);

    private void Start()
    {
        StartCoroutine(FlyAwayAfterDelay());
    }

    private IEnumerator FlyAwayAfterDelay()
    {
        gameObject.transform.DOLocalMoveY(32, 2f);
        yield return new WaitForSeconds(delayBeforeFlyAway);
        gameObject.transform.DOLocalMoveY(2160, 1.5f);
    }
}
