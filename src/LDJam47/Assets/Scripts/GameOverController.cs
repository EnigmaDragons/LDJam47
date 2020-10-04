using UnityEngine;


public class GameOverController : MonoBehaviour
{
	[SerializeField] private GameObject forHiding;

	private SceneLoader sceneLoader = null;

	private void Start()
	{
		forHiding.SetActive(false);

		sceneLoader = SceneLoader.SceneLoaderInstance;
	}

	public void Show()
	{
		forHiding.SetActive(true);
	}

	public void GoToMainMenu()
	{
		Time.timeScale = 1;

		sceneLoader.LoadMainMenu();
	}
}
