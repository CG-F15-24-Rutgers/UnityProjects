using UnityEngine;
using System.Collections;

public class ObstacleMove : MonoBehaviour {
	
	public float PlayerSpeed;
	NavMeshObstacle obs = null;
	
	void Start()
	{
		PlayerSpeed = 10;
	}
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Input.GetMouseButtonDown (0)) 
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			
			if (Physics.Raycast (ray, out hit, 300.0F)&& hit.transform.CompareTag ("obstacle"))
			{
				obs = hit.collider.gameObject.GetComponent<NavMeshObstacle> ();
				print (obs);
			}
			
		}

		print (obs);
		if (obs != null) 
		{
			float amtToMoveX = Input.GetAxisRaw("Vertical") * PlayerSpeed * Time.deltaTime;
			
			obs.transform.Translate(Vector3.right * amtToMoveX);
			float amtToMoveZ = Input.GetAxisRaw("Horizontal") * PlayerSpeed * Time.deltaTime;
			
			obs.transform.Translate(Vector3.forward * -amtToMoveZ);
		}
		
	}
}