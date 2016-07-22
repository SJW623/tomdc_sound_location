using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    int timer;
    public Transform cam;
	// Use this for initialization
	void Start () {
        timer = 0;

	}
    // Update is called once per frame
    void Update() {

        transform.Translate(transform.TransformDirection(Vector3.forward) * 3 * Time.deltaTime);
        if(timer >= 1000)
        {
            Destroy(gameObject);
        }
        timer++;
    }
}
