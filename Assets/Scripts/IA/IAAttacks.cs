using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class IAAttacks : MonoBehaviour
{
    private Animator animator;
    [SerializeField] Transform player;
    [SerializeField] int dmg = 5;
    private BoxCollider boxCollider;
    private bool atkTime = false;
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        animator = GetComponentInParent<Animator>();
        boxCollider.enabled = !boxCollider.enabled;
    }

    public void IAAttack()
    {
        atkTime = true;
        boxCollider.enabled = !boxCollider.enabled;
        StartCoroutine(attackTime());
        if (Random.Range(0,2) == 0)
            animator.SetTrigger("Attack_01");
        else
            animator.SetTrigger("Attack_02");
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < 2 && GetComponentInParent<IASensor>().ifdetected && !atkTime)
            IAAttack();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<Life>().life -= dmg;
            other.GetComponent<Life>().life = Mathf.Clamp(other.GetComponent<Life>().life, 0, 100);

            print(other.GetComponent<Life>().life);
        }
    }

    IEnumerator attackTime()
    {
        yield return new WaitForSeconds(3);
        boxCollider.enabled = !boxCollider.enabled;
        atkTime = false;
    }
}
