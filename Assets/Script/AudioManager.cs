using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //audio code ya
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;

    private void Start()
    {
        PlayBGM();
    }

    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    // Menggunakan UnityEngine.Vector3 dan UnityEngine.Quaternion untuk menghindari ambiguitas
    public void PlaySFX(Vector3 spawnPosition)
    {
        Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
