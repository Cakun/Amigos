using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonKeyClick : MonoBehaviour
{
    public Button clickButton;

    void Update()
    {;
        if(Input.GetKeyDown(KeyCode.Z))
        {
            clickButton.onClick.Invoke();
        }
    }
}
