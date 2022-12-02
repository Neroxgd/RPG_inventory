using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public int life = 100;

    void Update()
    {
        if (life <= 0)
        {
            // StartCoroutine(Death());
            animator.SetTrigger("death");
        }
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
