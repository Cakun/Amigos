using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCredits : MonoBehaviour
{
    public Animator _bounceCredits;

    void Start()
    {
        _bounceCredits = GetComponent<Animator>();
    }
    public void BounceCredits()
    {
        _bounceCredits.SetTrigger("ClickShow");
    }

    public void BounceSettings()
    {
        _bounceCredits.SetTrigger("SettingShow");
    }

    public void BounceMainMenu()
    {
        _bounceCredits.SetTrigger("MainMenuShow");
    }
}
