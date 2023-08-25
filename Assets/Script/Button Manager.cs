using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ButtonManager : MonoBehaviour
{
    public GameObject Test_UI;
    public Vector3 TargetPos;
    public float TravelTime;
    public void ButtonMovement() 
    {
        Test_UI.transform.DOLocalMove(TargetPos, TravelTime).SetEase(Ease.InOutElastic);
    }
}
