using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;
    public float life = 100;
    private bool InLife = true;

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
            Destroy(GetComponent<Move>());
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<DeathEffect>().Death();
            InLife = false;
        }
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

    public void currentLife()
    {
        _textMeshProUGUI.text = "life : " + (int)life;
    }
}
