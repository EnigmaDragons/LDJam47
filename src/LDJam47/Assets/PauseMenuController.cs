using UnityEngine;


public class PauseMenuController : MonoBehaviour
{
	[SerializeField] private GameObject forHiding;

	void Start()
    {

    }

    void Update()
    {
	    if (Input.GetAxis("Pause") > 0.01)
	    {
		    forHiding.SetActive(!forHiding.activeSelf); // toggle
	    }
    }
}
