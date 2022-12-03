using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeMob : MonoBehaviour
{
    public int lifeMob = 200;
    private bool InLife = true;
    void Start()
    {
        InLife = true;
        lifeMob = 200;
    }

    void Update()
    {
        if (lifeMob <= 0 && InLife)
        {
            GetComponent<DeathEffect>().Death();
            StartCoroutine(Death());
            InLife = false;
        }
    }
    IEnumerator Death()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
