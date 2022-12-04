using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;
    [SerializeField] private GameObject popo;
    public float life = 100;
    private bool InLife = true;

    public float MaxLife = 150;

    void Start()
    {
        InLife = true;
        life = 100;
    }

    void LateUpdate()
    {
        if (life <= 0 && InLife)
        {
            // StartCoroutine(Death());
            animator.SetTrigger("death");
            GetComponent<Move>().enabled = !GetComponent<Move>().enabled;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<DeathEffect>().Death();
            StartCoroutine(Death());
            InLife = false;
        }
        currentLife();
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(5);
        transform.position = new Vector3(53.4f, 0.7f, 51.53f);
        life = 100;
        InLife = true;
        GetComponent<DeathEffect>().InverseDeath();
        GetComponent<Move>().enabled = !GetComponent<Move>().enabled;
        GetComponent<Move>().moveSpeed = 10;
        Instantiate(popo, new Vector3(36.70f, 1.41f, 40.84f), Quaternion.Euler(-90, 0, 0));
        animator.SetTrigger("spawn");
    }

    public void currentLife()
    {
        _textMeshProUGUI.text = "life : " + (int)life;
    }
}
