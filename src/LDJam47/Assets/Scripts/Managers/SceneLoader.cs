using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    #region Singleton

    private static SceneLoader _instance;

    public static SceneLoader SceneLoaderInstance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Game Manager is null!");
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
        transitionAnimator = GetComponentInChildren<Animator>();
    }

    #endregion Singleton

    // Cached Components
    Animator transitionAnimator;

    private Animator Animator
    {
        get
        {
            if (transitionAnimator == null)
                transitionAnimator = GetComponentInChildren<Animator>();
            return transitionAnimator;
        }
    }
    
    public void ReloadScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        StartCoroutine(LoadSceneCoroutine(currentSceneIndex));
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        StartCoroutine(LoadSceneCoroutine(currentSceneIndex + 1));
    }

    public void LoadMainMenu()
    {
        StartCoroutine(LoadSceneCoroutine(0));
    }

    public void LoadSceneByName(string sceneName)
    {
        StartCoroutine(LoadSceneByNameCoroutine(sceneName));
    }

    public void FadeToBlack() => Animator.SetTrigger("fadeToBlack");

    public void FadeFromBlack() => Animator.SetTrigger("fadeFromBlack");


    IEnumerator LoadSceneCoroutine(int buildIndex)
    {
        Debug.Log("Loading Scene");
        FadeToBlack();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(buildIndex);
    }

    IEnumerator LoadSceneByNameCoroutine(string sceneName)
    {
        Debug.Log("Loading Scene");
        FadeToBlack();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
