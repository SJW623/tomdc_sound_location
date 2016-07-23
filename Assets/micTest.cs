using UnityEngine;
using System.Collections;
using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using UnityPlayer;

public class micTest : MonoBehaviour {

    public float sensitivtiy = 100;
    public float loudness = 0;


    // Use this for initialization
    void Start()
    {
        

        
    }
    void awake()
    {
        GetComponent<AudioSource>().clip = Microphone.Start(string.Empty, true, 1, 44100);

    }
    // Update is called once per frame
    void Update () {

        
        GetComponent<TextMesh>().text = "channels: " + GetComponent<AudioSource>().clip.channels;

    }

   
}
