using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    [SerializeField] private bool keyCount = false;
    public Text keytext;

    void Update()
    {
        keytext.text = keyCount.ToString();
    }
    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.CompareTag("Key"))
        {
            Destroy(obj.gameObject);
            keyCount = true;
        }
        else if (obj.gameObject.CompareTag("Portal2") && keyCount == true)
        {
            SceneManager.LoadScene("lvl2");
        }
    }
}