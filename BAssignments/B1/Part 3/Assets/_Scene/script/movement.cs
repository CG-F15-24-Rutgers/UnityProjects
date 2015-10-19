using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

    private Animator animator;
    private float hor;
    private float ver;
    private float run;
    private float jump;

    static int locostate = Animator.StringToHash("Base Layer.Run-WalkFwd");
    int jumpstate = Animator.StringToHash("jump");
    int runHash = Animator.StringToHash("Base Layer.run");
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        animator.SetFloat("speed", ver);
        animator.SetFloat("direction", hor);
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if(Input.GetKeyDown(KeyCode.Space) && stateInfo.fullPathHash == runHash)
        {
            animator.SetTrigger(jumpstate);
        }
        if(animator.IsInTransition(0))
        {
            animator.SetBool("jump", false);
        }
    }

    void FixedUpdate()
    {
    }
    
}
