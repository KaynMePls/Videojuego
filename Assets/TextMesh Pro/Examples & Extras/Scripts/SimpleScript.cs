using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargadorNivel : MonoBehaviour
{
    public void CargarNivel(int NumeroDeEscena)
    {
        StartCoroutine(CargarAsync(NumeroDeEscena));
    }

    IEnumerator CargarAsync(int NumeroDeEscena)
    {
        AsyncOperation Operacion = SceneManager.LoadSceneAsync(NumeroDeEscena);

        while (!Operacion.isDone)
        {
            Debug.Log(Operacion.progress);
            yield return null;
        }
    }
}
