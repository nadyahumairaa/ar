using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasiTombol : MonoBehaviour
{
    public void Animasi()
    {
        GetComponent<Animation>().Play("Button");
        KumpulanSuara.instance.Panggil_Suara(0);
    }

    public void AnimasiMainmenu()
    {
        GetComponent<Animation>().Play("Button");
    }
}
