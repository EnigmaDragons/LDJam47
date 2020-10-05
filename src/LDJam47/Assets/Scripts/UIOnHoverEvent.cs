using UnityEngine;
using UnityEngine.EventSystems;


public class UIOnHoverEvent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField] private float targetScaleModifier = 1.5f;
	[SerializeField] private int animationsLengthInFrames = 30;

	private Vector3 initialScale;
	private bool    enlarging             = false;
	private int     currentAnimationFrame = 0;

	void Start()
	{
		initialScale = transform.localScale;
	}

	private void Update()
	{
		transform.localScale = initialScale * Mathf.SmoothStep(1, targetScaleModifier, currentAnimationFrame/(float)animationsLengthInFrames);

		if (enlarging)
		{
			currentAnimationFrame++;
		}
		else
		{
			currentAnimationFrame--;
		}

		currentAnimationFrame = Mathf.Clamp(currentAnimationFrame, 0, animationsLengthInFrames);
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		enlarging = true;
		transform.SetAsLastSibling();
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		enlarging = false;
	}
}
