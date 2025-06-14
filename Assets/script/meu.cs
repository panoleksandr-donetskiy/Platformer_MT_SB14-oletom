using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meu : MonoBehaviour
{
    public GameObject[] menues;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickButton(int idx)
    {
        SceneManager.LoadScene(idx);
    }

    public void OnClickSelect()
    {
        menues[0].SetActive(false);
        menues[1].SetActive(true);
    }

    public void OnClickBack()
    {
        menues[0].SetActive(true);
        menues[1].SetActive(false);
    }
}
