using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gakeluar : MonoBehaviour
{
    public string MainMenuScene;

    public void GaKeluar()
    {
        SceneManager.LoadScene(MainMenuScene);
    }
}
