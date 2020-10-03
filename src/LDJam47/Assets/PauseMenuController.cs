using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
	[SerializeField] private GameObject forHiding;

    private bool paused = false;

	void Start()
    {

    }

    void Update()
    {
	    if (Input.GetAxis("Pause") > 0.01)
	    {
		    if (paused)
		    {
			    UnPause();
		    }
		    else
		    {
			    Pause();
		    }
	    }
    }

    public void UnPause()
    {
	    forHiding.SetActive(false);

	    Time.timeScale = 1;

	    paused = false;
    }

    public void Pause()
    {
	    forHiding.SetActive(true);

	    Time.timeScale = 0;

	    paused = true;
    }

    public void GoToMainMenu()
    {
	    SceneManager.LoadScene(0);
    }
}
