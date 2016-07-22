using UnityEngine;
using System.Collections;

public class InstanceTest : MonoBehaviour {
    public GameObject projectile;
    public GameObject ball;
    public float speed;
    public Transform cam;
    int timer;
    // Use this for initialization
    void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.LookAt(cam);
        if (timer >= 100)
        {
            Instantiate(projectile, gameObject.transform.position, gameObject.transform.rotation);

            

            timer = 0;
        }
        else
        {
            timer++;
        }
	}
}
