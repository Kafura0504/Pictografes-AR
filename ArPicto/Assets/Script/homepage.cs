using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homepage : MonoBehaviour
{

    public GameObject[] UI1;
    public GameObject[] UI2;
    public GameObject[] UI3;
    public GameObject[] bg;
    public GameObject hal1;
    public GameObject hal2;


    private int index = 0;


    void Start()
    {

    }

    void Update()
    {
        if (index == 0)
        {
            hal2.SetActive(false);
            hal1.SetActive(true);
        }
        else if (index == 1)
        {
            hal1.SetActive(false);
            hal2.SetActive(true);
        }
        else if (index == 3)
        {
            SceneManager.LoadScene("AR-section");
        }
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

    public void btnhandler()
    {
        index++;
        Debug.Log("jeruk limau" + index);
    }

    public void btnprevious()
    {
        index--;
    }
}
