using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSound : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("thecoldbattle");
        FindObjectOfType<AudioManager>().Stop("foreverlands");
        FindObjectOfType<AudioManager>().Play("mobview");
        Destroy(gameObject);
    }
}
