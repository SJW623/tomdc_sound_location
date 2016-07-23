using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    int timer;
    public Transform cam;
    public CharacterController charc;
	// Use this for initialization
	void Start () {
        timer = 0;
        charc.detectCollisions = false;
    }
    // Update is called once per frame
    void Update() {
      
        charc.Move(transform.TransformDirection(Vector3.forward) * 2 * Time.deltaTime);
      
        if(timer >= 1000)
        {
            Destroy(gameObject);
        }
        timer++;
    }
}
