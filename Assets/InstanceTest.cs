using UnityEngine;
using System.Collections;

public class InstanceTest : MonoBehaviour {
    public GameObject projectile;
    public GameObject ball;
    public GameObject compass;
    public GameObject arrow;
    public float speed;
    public float intensity;
    public Transform cam;
    GameObject arrow1;
    int timer;
    // Use this for initialization
    void Start () {
        timer = 0;
         arrow1 = (GameObject)Instantiate(arrow, compass.transform.position, transform.rotation);
        arrow1.transform.parent = compass.transform;
        
    }
	
	// Update is called once per frame
	void Update () {
        arrow1.transform.rotation = Quaternion.Euler(0, (180 / 3.14159f) * Mathf.Atan((float)((arrow1.transform.position.z - transform.position.z) / ((arrow1.transform.position.x - transform.position.x) + .01f))), 0);
        gameObject.transform.LookAt(cam);
        if (timer >= 30 / intensity)
        {

           // Instantiate(projectile, transform.position, transform.rotation);
            

            timer = 0;
        }
        else
        {
            timer++;
        }
	}
}
