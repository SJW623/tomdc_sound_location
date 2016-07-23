using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    int timer;
    public Transform cam;
    public Rigidbody rBody;
	// Use this for initialization
	void Start () {
        timer = 0;
       
    }
    // Update is called once per frame
    void Update() {
      
        rBody.velocity = (transform.TransformDirection(Vector3.forward) * 100 * Time.deltaTime);
      
        if(timer >= 2000)
        {
            Destroy(gameObject);
        }
        timer++;
    }
}
