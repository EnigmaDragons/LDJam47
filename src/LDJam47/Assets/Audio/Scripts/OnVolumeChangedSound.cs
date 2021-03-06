﻿using UnityEngine;
using UnityEngine.Audio;

public class OnVolumeChangedSound : OnMessage<MixerVolumeChanged>
{
    [SerializeField] private AudioClip sound;
    [SerializeField] private AudioSource player;
    [SerializeField] private AudioMixer mixer;

    private bool _triggered;
    private MixerVolumeChanged _lastChange;

    
    protected override void Execute(MixerVolumeChanged msg)
    {
        _triggered = true;
        _lastChange = msg;
    }

    private void Update()
    {
        if (!_triggered || Input.GetMouseButton(0)) return;

        _triggered = false;
        var mixerGroups = mixer.FindMatchingGroups(_lastChange.ChannelName.Replace("Volume", ""));

        if (mixerGroups.Length <= 0)
        {
            Debug.Log($"Audio - No Mixer Group for {_lastChange.ChannelName.Replace("Volume", "")} found.");
            return;
        }
        
        player.outputAudioMixerGroup =  mixerGroups[0];
        player.PlayOneShot(sound);
    }
}
