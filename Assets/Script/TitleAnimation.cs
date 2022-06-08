using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleAnimation : MonoBehaviour
{
    public Image fadeImage;

    void Start()
    {
        Invoke("ImageFadeEffect", 1);
    }

    public void ImageFadeEffect()
    {
       GameObject.Destroy(fadeImage);
    }
}
