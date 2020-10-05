using UnityEngine;

public class InitIntroLoopAudioPlayer : MonoBehaviour
{
    [SerializeField] private IntroLoopAudioPlayer player;

    protected void Start()
    {
        player.Init();
    }
}