using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private BoxCollider boxCollider;
    [SerializeField] int dmg = 5;

    void Start()
    {
        boxCollider.enabled = !boxCollider.enabled;
    }

    public void _Attack()
    {
        boxCollider.enabled = !boxCollider.enabled;
        animator.SetTrigger("punchRight");
        StartCoroutine(attackTime());
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mob"))
        {
            print("oui");
            other.GetComponent<Animator>().SetTrigger("Hit");
            other.GetComponent<LifeMob>().lifeMob -= dmg;
            print(other.GetComponent<LifeMob>().lifeMob);
            other.GetComponent<Animator>().ResetTrigger("Hit");
        }
        // print(other.GetComponentInChildren<LifeMob>().lifeMob);
    }

    IEnumerator attackTime()
    {
        yield return new WaitForSeconds(1);
        boxCollider.enabled = !boxCollider.enabled;
        animator.ResetTrigger("punchRight");
    }
}
