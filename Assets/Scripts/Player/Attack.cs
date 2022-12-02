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
        if (Random.Range(0,2) == 0)
            animator.SetTrigger("punchRight");
        else
            animator.SetTrigger("punchLeft");
        StartCoroutine(attackTime());
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mob"))
        {
            other.GetComponent<Animator>().SetTrigger("Hit");
            other.GetComponent<LifeMob>().lifeMob -= dmg;
            other.GetComponent<LifeMob>().lifeMob = Mathf.Clamp(other.GetComponent<LifeMob>().lifeMob, 0, 200);

            print(other.GetComponent<LifeMob>().lifeMob);
        }
    }

    IEnumerator attackTime()
    {
        yield return new WaitForSeconds(1);
        boxCollider.enabled = !boxCollider.enabled;
    }
}
