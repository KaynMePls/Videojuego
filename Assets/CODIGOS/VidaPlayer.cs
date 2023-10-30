using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;





public class VidaPlayer : MonoBehaviour
{
    public int  vidaActual;
    [SerializeField] int vidaTotal;
    [SerializeField] TMP_Text textVida;
    [SerializeField] GameObject panelPlayerMuerto;
    [SerializeField] Vector3 posicionInicial;
    

    



    // Start is called before the first frame update
    void Awake()
    {
       

        vidaActual = vidaTotal;
        posicionInicial = transform.position;
        textVida.text = "X " + vidaTotal;

    }

    // Update is called once per frame
    void Update()
    {

        textVida.text = "X " + vidaActual;
        if (vidaActual <= 0) {
            print("Murio");
            panelPlayerMuerto.SetActive(true);
            Time.timeScale = 0f;

        }


    }

    public void RestarVida(int restarVida) { 
        vidaActual -= restarVida;
    }

    public void reiniciar()
    {
        
        Time.timeScale = 1f;
        print("revivio");
        panelPlayerMuerto.SetActive(false);
        vidaActual = vidaTotal;
        transform.position = posicionInicial;

    }





}
