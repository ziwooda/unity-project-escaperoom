using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {
    public static BGM Instance;
    AudioSource music;

    private void Awake() {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Play() {
        if (Instance == null)
            music = gameObject.GetComponent<AudioSource>();
        else music = Instance.GetComponent<AudioSource>();
        music.enabled = true;
    }

    public void Stop() {
        if (Instance == null)
            music = gameObject.GetComponent<AudioSource>();
        else music = Instance.GetComponent<AudioSource>();
        music.enabled = false;
    }
}
