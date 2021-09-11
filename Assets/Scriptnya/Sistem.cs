using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sistem : MonoBehaviour
{
    public static Sistem instance;
    public int ID;
    public GameObject TempatSpawn;
    public GameObject Gui_utama;
    public GameObject[] KoleksiHewan;
    public AudioClip[] SuaraHewan;
    private AudioSource[] AllAudioClip;
    AudioSource Suara;

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ID = 0;
        //SpawnObject();
        Gui_utama.SetActive(false);
        Suara = gameObject.AddComponent<AudioSource>();
    }

    public void SpawnObject()
    {
        GameObject BendaSebelumnya = GameObject.FindGameObjectWithTag("Hewan");
        if (BendaSebelumnya != null) Destroy(BendaSebelumnya);

        GameObject Benda = Instantiate(KoleksiHewan[ID]);
        Benda.transform.SetParent(TempatSpawn.transform, false);
        Benda.transform.localScale = new Vector3(15, 15, 15);
        TempatSpawn.GetComponent<Animation>().Play("PopUp");
        //suaratrampolin
        KumpulanSuara.instance.Panggil_Suara(1);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            GantiHewan(true);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GantiHewan(false);
        }
    }

    public void GantiHewan(bool Kanan)
    {
        if(Kanan)
        {
            if(ID >= KoleksiHewan.Length -1)
            {
                ID = 0;
            }
            else
            {
                ID++;
            }
        }
        else
        {
            if (ID <= 0)
            {
                ID = KoleksiHewan.Length - 1;
            }
            else
            {
                ID--;
            }
        }

        SpawnObject();
        PanggilSuaraHewan();
    }

    public void PanggilSuaraHewan()
    {
        Suara.clip = SuaraHewan[ID];
        Suara.Play();
    }

    public void StopAllAudio()
    {
        AllAudioClip = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in AllAudioClip)
        {
            audioS.Stop();
        }
    }
}
