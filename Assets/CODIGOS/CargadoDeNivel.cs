using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CargadoDeNivel : MonoBehaviour
{
    [SerializeField] private Slider loadbar;
    [SerializeField] private GameObject loadPanel;

    public void SceneLoad(int sceneIndex)
    {
        StartCoroutine(LoadAsync(sceneIndex)); // Inicia la carga asincrónica
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        loadPanel.SetActive(true); // Activa el panel de carga

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
            loadbar.value = progress; // Actualiza el valor de la barra de carga
            yield return null;
        }
    }
}
