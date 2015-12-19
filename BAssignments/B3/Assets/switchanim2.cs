using UnityEngine;
using System.Collections;

public class switchanim2 : MonoBehaviour
{

    Animator animator, animator_t, animator_c;
    // Animator initial_anim, initial_anim_c, initial_anim_t;
    public GameObject move, character, cop, theif;
    public GameObject sk_cam, t_cam, c_cam, main_cam;
    NavMeshAgent agent = null;
    string t = null;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        animator_t = theif.GetComponent<Animator>();
        animator_c = cop.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit hit;
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    if (Physics.Raycast(ray, out hit, 1000.0F) )
        //    {

        //        // t = hit.collider.gameObject.GetComponent<Transform>();
        //        t = hit.collider.gameObject.ToString();
        //        print(t);
        //    }


        //}
        //if (agent != null)
        //{
        //    animator.runtimeAnimatorController = (RuntimeAnimatorController)RuntimeAnimatorController.Instantiate(Resources.Load("Scene/bi-ped/movement.controller"));


        //}

       
           
            animator_c.runtimeAnimatorController = move.GetComponent<Animator>().runtimeAnimatorController;
            animator_t.runtimeAnimatorController = character.GetComponent<Animator>().runtimeAnimatorController;
            animator.runtimeAnimatorController = character.GetComponent<Animator>().runtimeAnimatorController;

       


    }
}
