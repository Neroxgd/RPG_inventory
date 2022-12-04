using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeMob : MonoBehaviour
{
    public int lifeMob = 200;
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject wallwin;
    private bool InLife = true;
    void Start()
    {
        InLife = true;
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
        if (wall != null)
            Destroy(wall);
        else 
            Destroy(wallwin);
        Destroy(gameObject);
    }
}
