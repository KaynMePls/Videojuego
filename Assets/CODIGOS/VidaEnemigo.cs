using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class vidaEnemigo : MonoBehaviour
{
    public int vidaActual;
    [SerializeField] int vidaTotal;

    // Start is called before the first frame update
    void Awake()
    {
        vidaActual = vidaTotal;
    }

    // Update is called once per frame
    void Update()
    {

        if (vidaActual <= 0)
        {
            print("Murio");
            this.gameObject.SetActive(false);
        }
    }

    public void RestarVida(int restarVida)
    {
        vidaActual -= restarVida;
    }
}
