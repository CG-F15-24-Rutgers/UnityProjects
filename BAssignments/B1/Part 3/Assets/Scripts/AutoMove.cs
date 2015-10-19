using UnityEngine;
using System.Collections;

public class AutoMove : MonoBehaviour {
	
	// Use this for initialization

	private float currTime;
	private float prevTime;
	private Vector3 currPos;
	private bool flag;
	void Start () {
		prevTime = Time.time;
		currTime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		currPos = transform.transform.TransformPoint (Vector3.zero);
		currTime = Time.time;
		if (currPos.x < -20)
			flag = false;
		if (currPos.x > 20)
			flag = true;
		if (currTime - prevTime > 0.02f && flag == false) {
			


			transform.position= currPos+(new Vector3 (0.2f, 0, 0) );
			
			
			prevTime = currTime;
			
		}
		if (currTime - prevTime > 0.02f && flag == true) {
			transform.position = currPos + (new Vector3 (-0.2f, 0, 0));
			prevTime = currTime;
		}
	}
	
	
}
