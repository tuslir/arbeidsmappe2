using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMusic : MonoBehaviour
{
    private AudioSource _audioSource;

    private static SceneMusic instance = null;

    public static SceneMusic Instance
    {
        get { return instance; }
    }


    private void Awake()
    {
        GameObject.FindGameObjectWithTag("MenuMusic").GetComponent<MusicClass>().StopMusic();

        _audioSource = GetComponent<AudioSource>();

        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }

}
