using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpSystem : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator;
    public TMP_Text PopUpText;

    public void PopUp (string text)
    {
        popUpBox.SetActive(true);
        PopUpText.text = text;
        animator.SetTrigger("pop");
    }

}
