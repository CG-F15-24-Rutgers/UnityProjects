using UnityEngine;
using System.Collections;

public class buttoncontroller : MonoBehaviour {

    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
    }
}
