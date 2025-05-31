using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class homepage : MonoBehaviour
{
    public GameObject[] UI1;
    public GameObject[] bg;
    public GameObject hal1;
    public GameObject hal2;
    public GameObject sec1;
    public GameObject sec2;
    public Animation progression;
    public Button btn;
    public Button backbtn;


    private int index = 0;
    private int lastindex;
    private bool isTransitioning;

    void Start()
    {
        foreach (AnimationState state in progression)
        {
            Debug.Log("Found clip: " + state.name);
        }

    }

    void Update()
    {
        if (index == 0 && lastindex == 1 && !isTransitioning)
        {
            h1();
            progression.Play("hal1");
            StartCoroutine(buttondisabler());
        }
        else if (index == 1 && lastindex == 0 && !isTransitioning)
        {
            h2();
            progression.Play("Hal2");
            StartCoroutine(buttondisabler());

        }
        else if (index == 2 && lastindex == 1 && !isTransitioning)
        {
            h3();
            progression.Play("hal3");
            StartCoroutine(buttondisabler());
        }
        else if (index == 1 && lastindex == 2 && !isTransitioning)
        {
            h2();
            progression.Play("hal2rev");
            StartCoroutine(buttondisabler());
        }
        else if (index == 3)
        {
            SceneManager.LoadScene("AR-section");
        }
    }


    public void btnhandler()
    {
        lastindex = index;
        index++;
        Debug.Log("jeruk limau" + index);
    }

    public void btnprevious()
    {
        lastindex = index;
        index--;
    }

    void h1()
    {
        hal2.SetActive(false);
        hal1.SetActive(true);
    }
    void h2()
    {
        hal1.SetActive(false);
        hal2.SetActive(true);
        sec1.SetActive(true);
        sec2.SetActive(false);
    }
    void h3()
    {
        hal1.SetActive(false);
        hal2.SetActive(true);
        sec1.SetActive(false);
        sec2.SetActive(true);
    }

    public IEnumerator buttondisabler()
    {
        isTransitioning = true;
        btn.interactable = false;
        backbtn.interactable = false;

        yield return new WaitForSeconds(1f); // Or match animation length

        btn.interactable = true;
        backbtn.interactable = true;
        isTransitioning = false;
        lastindex = -1;
    }
}
