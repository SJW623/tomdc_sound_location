using UnityEngine;
using System.Collections;

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
