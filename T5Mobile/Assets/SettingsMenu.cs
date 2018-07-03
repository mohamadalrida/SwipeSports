using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {

    public AudioMixer audioSFX;
    public AudioMixer audioMusic;

	public void SetVolumeSFX (float SFXVolume)
    {
        audioSFX.SetFloat("SFXVolume", SFXVolume);
    }

    public void SetVolumeMusic(float Musicvolume)
    {
        audioMusic.SetFloat("MusicVolume", Musicvolume);
    }
}
