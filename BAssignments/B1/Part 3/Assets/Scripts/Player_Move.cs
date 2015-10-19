using UnityEngine;
using System.Collections;

public class Player_Move : MonoBehaviour {
	
	//public Transform goal;
	NavMeshAgent agent;
	NavMeshObstacle obstacle;
	private float hor;
	private float ver;
	private GameObject gameOject;
	private Animator anim ;
	private bool flag;

	static int locostate = Animator.StringToHash("Base Layer.Run-WalkFwd");
	int jumpstate = Animator.StringToHash("jump");
	int runHash = Animator.StringToHash("Base Layer.run");


	// Use this for initialization
	void Start()
	{
		agent = null; //GetComponent<NavMeshAgent>();
		obstacle = null;
		anim = null;
	}
	
	// Update is called once per frame
	void Update () {

		hor = Input.GetAxis ("Horizontal1");
		ver = Input.GetAxis ("Vertical1");
		RaycastHit hit;
		//float moveHorizontal = Input.GetAxis("horizontal");
		//float moveVertical = Input.GetAxis("vertical");
		
		//Select the agent to move and move
		if (Input.GetMouseButtonDown (0)) 
		{ 
			print ("1");
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			//select Agent

			if (Physics.Raycast (ray, out hit, 300)) 
			{
				print ("2");

				if (hit.transform.CompareTag ("capsule")) {
					print ("3");
					agent = hit.collider.gameObject.GetComponent<NavMeshAgent> ();
					anim = agent.GetComponent<Animator> ();

				}
				print ("anim" + anim);

			}

		}

				if (anim != null)
				{	print ("4");
					anim.SetFloat("speed",ver);
					anim.SetFloat("direction",hor);
					AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
						if(Input.GetKeyDown(KeyCode.Space)&& stateInfo.fullPathHash == runHash)
					{
						anim.SetTrigger(jumpstate);

					}
						if(anim.IsInTransition(0))
					{
						anim.SetBool("jump",false);

					}

				}
				
				
			
			
		}
		

}


