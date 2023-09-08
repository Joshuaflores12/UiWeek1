
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class ButtonManager : MonoBehaviour
{
    public GameObject Test_UI;
    public Vector3 TargetPos, ReturnlPos, originalPos;
    public Vector3 targetSize;
    public Vector3 targetRotation;
    public GameObject targetGameObj;
    public float TravelTime;
    public float speed;
    public Image targetImage;
    public float FadeDuration;
    public float RotationDuration;

    public void ButtonMovement() 
    {
        //Test_UI.transform.DOLocalMove(TargetPos, TravelTime).SetEase(Ease.InOutElastic);
    }

    public void MoveTween() 
    {
        targetGameObj.transform.DOLocalMove(TargetPos, speed).SetEase(Ease.Linear).OnComplete(() => ReturnPos());  
    }

    public void ReturnPos() 
    {
        targetGameObj.transform.DOLocalMove(originalPos, speed).SetEase(Ease.Linear);
    }

    public void ScaleTween() 
    {
       targetGameObj.transform.DOScale(Vector3.zero, speed).SetEase(Ease.Linear);   
    }

    public void FadeTween() 
    {
    targetImage.DOFade(0,FadeDuration);
    }

    public void Sequence() 
    {
    Sequence sequence = DOTween.Sequence();
        // 1st task
    sequence.Append(targetGameObj.transform.DOLocalMove(TargetPos, speed ).SetEase(Ease.Linear));
        // delay for 2nd task
        sequence.AppendInterval(2);
        //2nd task
        sequence.Append(targetGameObj.transform.DOScale(Vector3.one,speed).SetEase(Ease.Linear));
        //delay for 3rd task
        sequence.AppendInterval(2);
        sequence.Append(targetGameObj.transform.DOLocalMove(originalPos,speed).SetEase(Ease.Linear).OnComplete(() =>ReturnPos()));
    }

    public void RotationTween() 
    {
        targetGameObj.transform.DOLocalRotate(targetRotation, RotationDuration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
    }


}
