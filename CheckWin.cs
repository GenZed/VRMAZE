using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    public GameObject WinMessage;
    // Start is called before the first frame update
    void Start()
    {
        WinMessage.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("MainCamera"))
        {

           // if (WinMessage.activeInHierarchy)
                WinMessage.SetActive(true);
        }
    }
}
