using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuContol : MonoBehaviour
{
    public string About;
    public string ARnya;
    public string MainMenu;
    public string Popup;
    public string ScrollView;

    public void MainMenuScene()
    {
        SceneManager.LoadScene(MainMenu);
    }

    public void AboutScene()
    {
        SceneManager.LoadScene(About);
    }

    public void ARnyaScene()
    {
        SceneManager.LoadScene(ARnya);
    }

    public void ScrollViewScene()
    {
        SceneManager.LoadScene(ScrollView);
    }

    public void ExitScene()
    {
        SceneManager.LoadScene(Popup);
    }
}