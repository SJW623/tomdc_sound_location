﻿using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class micTest : MonoBehaviour {

 


    // Use this for initialization
    void Awake()
    {

        GetComponent<AudioSource>().clip = Microphone.Start(string.Empty, true, 10, 44100);

        GetComponent<TextMesh>().text = "channels: " + GetComponent<AudioSource>().clip.channels;
    }
  
    // Update is called once per frame
    void Update () {

        
       

    }

   
}
