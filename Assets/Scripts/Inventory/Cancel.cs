using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cancel : MonoBehaviour
{
    public GameObject panel;

    public void CancelPanel()
    {
        panel.SetActive(false);
    }
}
