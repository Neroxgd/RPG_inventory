using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;
    public int life = 100;

    void LateUpdate()
    {
        if (life <= 0)
        {
            // StartCoroutine(Death());
            animator.SetTrigger("death");
            Destroy(GetComponent<Move>());
        }
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

    public void currentLife()
    {
        _textMeshProUGUI.text = "life : " + life;
    }
}
