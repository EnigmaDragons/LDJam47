﻿using E7.Introloop;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu]
public class IntroLoopAudioPlayer : ScriptableObject
{
    [SerializeField] private IntroloopAudio currentClip;
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private FloatReference reductionDb = new FloatReference();
    [SerializeField] private string volumeValueName = "MusicVolume";
    [SerializeField] private string mixerGroupName = "Music";

    public void Init()
    {
        var mixerGroup = mixer.FindMatchingGroups(mixerGroupName)[0];
        Debug.Log($"Audio - IntroLoop - Mixer Group - {mixerGroup.name}");
        IntroloopPlayer.Instance.SetMixerGroup(mixerGroup);
        currentClip = null;
    }
    
    public void PlaySelectedMusicLooping(IntroloopAudio clipToPlay)
    {
        if (currentClip != null && currentClip.name == clipToPlay.name) return;
        
        currentClip = clipToPlay;
        var volume = PlayerPrefs.GetFloat(volumeValueName, 0.75f);
        mixer.SetFloat(volumeValueName, VolumeCalculation.GetVolumeDecibels(volume, reductionDb));
        IntroloopPlayer.Instance.Play(clipToPlay);
    
    }
}
