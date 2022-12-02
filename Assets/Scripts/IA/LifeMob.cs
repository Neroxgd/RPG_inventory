using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeMob : MonoBehaviour
{
    public Animator animator;
    public int lifeMob = 200;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lifeMob < 0)
        {
            StartCoroutine(Death());
        }
    }
    IEnumerator Death()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
