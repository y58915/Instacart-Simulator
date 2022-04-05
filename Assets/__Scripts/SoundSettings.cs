using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    const int BGM = 0;
    const int SFX = 1;
    static float[] volume = {1.0f , 1.0f};
    // public AudioClip[] clips;

    AudioSource[] sources;
    
    // Start is called before the first frame update
    void Start()
    {
        sources = GetComponentsInChildren<AudioSource>(); // the order is BGM, SFX
        ChangeBGMVolume(volume[BGM]);
        ChangeSFXVolume(volume[SFX]);

        Slider[] sliders = GetComponentsInChildren<Slider>(true);
        sliders[BGM].value = volume[BGM];
        sliders[SFX].value = volume[SFX];
    }

    void ChangeVolume(int type, float num){
        volume[type] = num;
        sources[type].volume = num;
    }

    public void ChangeBGMVolume(float num){
        ChangeVolume(BGM, num);
    }
    public void ChangeSFXVolume(float num){
        ChangeVolume(SFX, num);
    }
}