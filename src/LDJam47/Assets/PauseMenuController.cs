using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
	[SerializeField] private GameObject forHiding;
	[SerializeField] private  GameObject mainPauseMenu;

    private bool paused = false;
    private bool isPauseAxisInUse = false;

	void Start()
	{
		forHiding.SetActive(false);
	}

    void Update()
    {
	    if (Input.GetAxisRaw("Pause") != 0)
	    {
		    if(isPauseAxisInUse == false)
		    {
			    isPauseAxisInUse = true;

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

	    if (Input.GetAxisRaw("Pause") == 0)
	    {
		    isPauseAxisInUse = false;
	    }
    }

    public void UnPause()
    {
	    if (!mainPauseMenu.activeSelf)
	    {
			return;
	    }

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
	    Time.timeScale = 1;

	    SceneManager.LoadScene(0);
    }
}
