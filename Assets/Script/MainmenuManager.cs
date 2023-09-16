using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MainmenuManager : MonoBehaviour
{
    public RectTransform mainMenu, LobbyMenu, PopupLogin;
    public float uiTransitionSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowPlayMenu() 
    {
        LobbyMenu.DOAnchorPos(Vector2.zero, uiTransitionSpeed).SetEase(Ease.InQuint);
        mainMenu.DOAnchorPos(new Vector2(-1927, 0), uiTransitionSpeed, true).SetEase(Ease.Linear);
    }

    public void LoginUI() 
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append (PopupLogin.DOAnchorPos(Vector2.zero, 0, true));
        sequence.Append(PopupLogin.DOScale(Vector2.zero, 0));
        sequence.AppendInterval(0.2f); 
        sequence.Append(PopupLogin.DOScale(Vector2.one,0.2f)).SetEase(Ease.InOutElastic);
    }

    public void HideLoginUI() 
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(PopupLogin.DOScale(Vector2.zero, 0.1f));
        sequence.AppendInterval(0.1f);
        sequence.Append(PopupLogin.DOAnchorPos(new Vector2(-1927 , 0), 0, true));
        sequence.Append(PopupLogin.DOScale(Vector2.one , 0));

    }

}
