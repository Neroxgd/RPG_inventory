using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class IAAttacks : MonoBehaviour
{
    private Animator animator;
    [SerializeField] Transform player;
    [SerializeField] int dmg = 5;
    [SerializeField] private VisualEffect VFXGraph;
    private BoxCollider boxCollider;
    private bool atkTime = false;
    private bool laser = false;
    [SerializeField] private float atkDistance = 2;
    [SerializeField] private Life _life;
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        animator = GetComponentInParent<Animator>();
        boxCollider.enabled = !boxCollider.enabled;
    }

    public void IAAttack()
    {
        atkTime = true;
        StartCoroutine(attackTime());
        if (Random.Range(0, 2) == 0)
            animator.SetTrigger("Attack_01");
        else
            animator.SetTrigger("Attack_02");
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < 2 && GetComponentInParent<IASensor>().ifdetected && !atkTime && gameObject.tag == "Minotaur")
            IAAttack();
        else if (Vector3.Distance(transform.position, player.position) < atkDistance && GetComponentInParent<IASensor>().ifdetected && !atkTime && gameObject.tag == "Gorgon")
            ATKDistance();
        if (laser)
            _life.life -= 2f * Time.deltaTime;
        print(_life.life);
    }

    public void ATKDistance()
    {
        print("aaaa");
        atkTime = true;
        StartCoroutine(attackTime());
        VFXGraph.Play();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Vector3.Distance(transform.position, player.position) < 2 && gameObject.tag == "Minotaur")
                other.GetComponent<Life>().life -= dmg;
            else if (Vector3.Distance(transform.position, player.position) < atkDistance && gameObject.tag == "Gorgon")
                laser = true;
            other.GetComponent<Life>().life = Mathf.Clamp(other.GetComponent<Life>().life, 0, 100);
            other.GetComponent<Life>().currentLife();

            print(other.GetComponent<Life>().life);
        }
    }

    IEnumerator attackTime()
    {
        yield return new WaitForSeconds(1f);
        boxCollider.enabled = !boxCollider.enabled;

        yield return new WaitForSeconds(2f);
        atkTime = false;
        laser = false;
        boxCollider.enabled = !boxCollider.enabled;
    }
}
