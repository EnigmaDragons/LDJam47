using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class OnStart : MonoBehaviour
{
    [SerializeField] private UnityEvent action;
    [SerializeField] private FloatReference delay;

    private void Start() => StartCoroutine(Go());

    private IEnumerator Go()
    {
        yield return new WaitForSeconds(delay);
        action.Invoke();
    }
}
