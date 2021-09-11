using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loadingcontroller : MonoBehaviour
{
    public Transform loadingbar;
    public string MainMenuScene;

    [SerializeField]
    private float currentAmount;
    [SerializeField]
    private float speed;

    //update is called once per frame

    void Update()
    {
        if (currentAmount < 80)
        {
            currentAmount += speed * Time.deltaTime;
            Debug.Log((int)currentAmount);
        }
        else
        {
            SceneManager.LoadScene(MainMenuScene);
        }

        loadingbar.GetComponent<Image>().fillAmount = currentAmount / 80;
    }
}
