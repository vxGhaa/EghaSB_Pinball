using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxAudioSource;


    public void PlayVFX(Vector3 spawnPosition)
    {
        Instantiate(vfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
