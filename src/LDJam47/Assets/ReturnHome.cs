using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnHome : MonoBehaviour
{
    SceneLoader sceneLoader = null;
    // Start is called before the first frame update
    void Start()
    {
        sceneLoader = SceneLoader.SceneLoaderInstance;
        StartCoroutine(GoHome());
    }
    private IEnumerator GoHome()
    {
        yield return new WaitForSeconds(3f);
        sceneLoader.LoadSceneByName("DateScene");
    }
}
