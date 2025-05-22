using System.Collections;
using UnityEngine;

public class homepage : MonoBehaviour
{

    public GameObject[] UI1;
    public GameObject[] UI2;
    public GameObject[] UI3;
    public GameObject[] bg;

    private int index;


    void Start()
    {

    }

    void Update()
    {

    }

    public IEnumerator firstpage()
    {
        for (int i = 0; i < UI1.Length; i++)
        {
            Animator anim = UI1[i].GetComponent<Animator>();
            UI1[i].SetActive(true);
            anim.Play(UI1[i].name + "in");
            yield return new WaitForSeconds(0.5f);
        }

    }

    public IEnumerator baground()
    {
        for (int i = 0; i < bg.Length; i++)
        {
            Animator anim = bg[i].GetComponent<Animator>();
            bg[i].SetActive(true);
            anim.Play(bg[i].name + "in");
            yield return new WaitForSeconds(0.5f);
        }
    }
    
    
}
