using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class VulumeChanger : MonoBehaviour
{
    const string MusicVolume = nameof(MusicVolume);
    const string EffectsVolume = nameof(EffectsVolume);
    const string MasterVolume = nameof(MasterVolume);

    [SerializeField] private AudioMixerGroup _mixer;

    private float _baseVolume = 1;

    private void Start() => GetComponent<Slider>().value = _baseVolume;

    public void ChangeVolumeMaster(float volume) => _mixer.audioMixer.SetFloat(MasterVolume, Mathf.Log10(volume) * 20);

    public void ChangeVolumeMusic(float volume) => _mixer.audioMixer.SetFloat(MusicVolume, Mathf.Log10(volume) * 20);

    public void ChangeVolumeEffects(float volume) => _mixer.audioMixer.SetFloat(EffectsVolume, Mathf.Log10(volume) * 20);
}