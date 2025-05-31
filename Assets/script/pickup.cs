using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    [SerializeField] private int countjewl = 0;
    Text jeweltext;

    void Start()
    {
        
    }


    void Update()
    {
        jeweltext.text = ToString(countjewl);
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.CompareTag("jewl"))
        {
            Destroy(obj.gameObject);
            countjewl++;
        }
    }
}
