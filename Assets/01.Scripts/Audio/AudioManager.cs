using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider masterSlider;
    [SerializeField] private Slider sfxSlider;
    [SerializeField] private Slider bgmSlider;
    [SerializeField] private AudioSource sfxAudioSource;
    [SerializeField] private AudioClip[] sfxSource;

    public enum SFX
    {
        Go,
        Shot,
        GameOver,
        Win,
        Down

    }


    private void Awake()
    {
        
    }

    public void PlaySfx(SFX sfx)
    {
        int index = (int)sfx;

        if (index >= 0 && index < sfxSource.Length)
        {
            sfxAudioSource.PlayOneShot(sfxSource[index]);
        }
        else
        {
            Debug.LogWarning("SFX 인덱스 범위 초과" + sfx);
        }
    }
}
