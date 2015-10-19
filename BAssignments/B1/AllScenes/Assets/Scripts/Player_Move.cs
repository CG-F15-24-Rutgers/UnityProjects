using UnityEngine;
using System.Collections;

public class Player_Move : MonoBehaviour {
	
	//public Transform goal;
	NavMeshAgent agent;
	NavMeshObstacle obstacle;
	private GameObject gameOject;
	// Use this for initialization
	void Start()
	{
		agent = null; //GetComponent<NavMeshAgent>();
		obstacle = null;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		//float moveHorizontal = Input.GetAxis("horizontal");
		//float moveVertical = Input.GetAxis("vertical");
		
		//Select the agent to move and move
		if (Input.GetMouseButtonDown(0))
		{ 
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//select Agent
			if (Physics.Raycast(ray, out hit, 3000))
			{
				if(hit.transform.CompareTag("capsule"))
				{
					agent = hit.collider.gameObject.GetComponent<NavMeshAgent>();
				}
				if (agent != null)
				{
					agent.SetDestination(hit.point);
				}
				if (hit.transform.CompareTag("obstacle"))
				{
					//print("Obstacle");
					obstacle = hit.collider.gameObject.GetComponent<NavMeshObstacle>();
				}
				if (obstacle != null)
				{
					if (Input.GetKeyDown(KeyCode.LeftArrow))
					{
						print("Obstacle not null");
						obstacle.transform.Translate(1, 0, 0);
						//obstacle.transform.position += new Vector3(1.0f, 0.0f, 0.0f);
					}
				}
			}
			
		}
		
	}
}


