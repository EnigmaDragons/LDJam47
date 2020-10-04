using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    [Header("Position she would go to at the start of the date.")]
    public Vector3 walkInPos = Vector3.zero;
    public Vector3 startingPos = Vector3.zero;

    // Cached Components
    Animator animator = null;
    SpriteRenderer facialExpressionRenderer = null;

    // State
    [Header("ORDER: Happy, Angry, Confused")] // for convenience
    [SerializeField] Sprite[] facialExpressions = null;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        facialExpressionRenderer = GameObject.Find("Face Expression").GetComponentInChildren<SpriteRenderer>();
        startingPos = transform.localPosition;
    }

    public void SetTrigger(string triggerName) => animator.SetTrigger(triggerName);

    public void MoveCharacter(Vector3 origin, Vector3 destination, float duration) => 
        StartCoroutine( MoveCharacterTo(origin, destination, duration) );

    // Happy, Angry, Confused
    public void ChangeFacialExpression(string expressionName)
    {
        Debug.Log("Changing facial expression to: " + expressionName);
        switch (expressionName)
        {
            case "Happy":
                Debug.Log(facialExpressions[0]);
                facialExpressionRenderer.sprite = facialExpressions[0];
                break;
            case "Angry":
                facialExpressionRenderer.sprite = facialExpressions[1];
                break;
            case "Confused":
                facialExpressionRenderer.sprite = facialExpressions[2];
                break;
        }
    }

    IEnumerator MoveCharacterTo(Vector3 origin, Vector3 destination, float duration)
    {
        SetTrigger("walkTrigger");

        for (float t = 0f; t < duration; t += Time.deltaTime)
        {
            transform.localPosition = Vector3.Lerp(origin, destination, t / duration);
            yield return 0;
        }
        transform.position = destination;

        SetTrigger("standingTrigger");
    }
}
