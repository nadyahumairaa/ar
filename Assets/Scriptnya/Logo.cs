using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logo : MonoBehaviour
{
    public Image logoImage;
    public string splashLevel;

    IEnumerator Start()
    {
        logoImage.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(3f);

        FadeOut();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(splashLevel);
    }

    void FadeIn()
    {
        logoImage.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeOut()
    {
        logoImage.CrossFadeAlpha(0.0f, 2.5f, false);
    }
}
