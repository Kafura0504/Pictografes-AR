using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;


public class KangAturScript : MonoBehaviour
{
    public TrackableAR[] tr;
    public string[] nama;
    [TextArea]
    public string[] deskripsi;
    
    [Header("UI Deskripsi")]
    public TMP_Text txtNama;
    public TMP_Text txtDeskripsi;

    public GameObject goNama;
    public GameObject goDeskripsi;
    public GameObject Penanda;

    public bool[] cekMarker;
    int CountMarker;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cekMarker = new bool[tr.Length];
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0 ; i<tr.Length; i++)
        {
            if (tr[i].GetMarker())
            {
                txtNama.text = nama[i];
                txtDeskripsi.text = deskripsi[i];

                if(!cekMarker[i])
                {
                    CountMarker++;
                    cekMarker[i] = true;
                }
            }
            else 
            {
                if (cekMarker[i])
                {
                    CountMarker--;
                    cekMarker[i] = false;
                }
            }
        }
        DeskripsiPanel();
    }

    private void DeskripsiPanel()
    {
        if(CountMarker == 0 )
        {
            goNama.SetActive(false);
            goDeskripsi.SetActive(false);

            Penanda.SetActive(true);
        }
        else if (CountMarker==1){
            goNama.SetActive(true);
            goDeskripsi.SetActive(true);

            Penanda.SetActive(false);
        }
    }
}
