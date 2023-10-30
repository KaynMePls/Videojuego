using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtaqueQuitaVida : MonoBehaviour
{
    [SerializeField] int dano=1;
    [SerializeField] float TimeAnimation;
    [SerializeField] Animator anim;
    [SerializeField] string nameAnimationAttack; // Referencia al Animator
    [SerializeField] string nameAnimationIdle; // Referencia al Animator

    // Update is called once per frame
    void Update()
    {
        // Ataque
        if (Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(AtaqueDelay());
        }
    }

    IEnumerator AtaqueDelay()
    {
        this.GetComponent<BoxCollider2D>().enabled = true;
        anim.Play(nameAnimationAttack);
        yield return new WaitForSeconds(TimeAnimation);
        anim.Play(nameAnimationIdle);
        this.GetComponent<BoxCollider2D>().enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemigo"))
        {
                other.GetComponent<vidaEnemigo>().RestarVida(dano);
                print("Trigger");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            collision.gameObject.GetComponent<vidaEnemigo>().RestarVida(dano);
            print("Collider");
        }
    }
}
