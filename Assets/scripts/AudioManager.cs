using UnityEngine;
using System;



public class AudioManager : MonoBehaviour 
{
    public static AudioManager instance;
    public bool MusicStart = true;
    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private void Awake() 
    {
        if (instance == null) 
            {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else { Destroy(gameObject); }
    }

    public void Start() 
    {
        
       PlayMusic("Theme");
        
    }

    private void Update() {
        if (MusicStart == false) 
        {
            PlayMusic("Theme");
        }
    }



    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);
    
       if (s == null)  
        {
        Debug.Log("Sound not Found");
        }
        else 
        {
        musicSource.clip = s.clip;
        musicSource.Play();
        MusicStart = true;
        }
    }
    public void PlaySFX(string name) 
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null) 
        {
            Debug.Log("Sound not Found");
        } 
        else 
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }

}

