using UnityEngine;
using System.Collections;

public class GUI1 : MonoBehaviour {

   public Transform target;
    Vector3 pos;
    public Texture2D trackIcon;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    void OnGui()
    {

        Vector3 screenPos = Camera.main.WorldToScreenPoint(target.position);
        float  reverse = Screen.height;
        float clampX = Mathf.Clamp(screenPos.x, 0, Screen.width - (trackIcon.width / 2));
        float clampY = Mathf.Clamp(reverse - screenPos.y, 0, Screen.height - (trackIcon.height / 2));

        GUI.DrawTexture(new Rect(clampX, clampY, trackIcon.width / 2, trackIcon.height / 2), trackIcon);
    }
}
