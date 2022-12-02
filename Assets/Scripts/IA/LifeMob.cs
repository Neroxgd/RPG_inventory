using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeMob : MonoBehaviour
{
    public int lifeMob = 200;

    void Update()
    {
        if (lifeMob <= 0)
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
