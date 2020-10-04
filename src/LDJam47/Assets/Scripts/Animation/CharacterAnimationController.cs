using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    [Header("Position she would go to at the start of the date.")]
    public Vector3 walkInPos = Vector3.zero;

    // Cached Components
    Animator animator = null;

    // State
    public Vector3 startingPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        startingPos = transform.localPosition;
    }

    public void SetTrigger(string triggerName) => animator.SetTrigger(triggerName);

    public void MoveCharacter(Vector3 origin, Vector3 destination, float duration) => 
        StartCoroutine( MoveCharacterTo(origin, destination, duration) );

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
