using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPipette1 : MonoBehaviour
{
    public GameObject parent1;
    private void OnMouseDrag()
    {
        var anim = parent1.GetComponent<Animator>();
        anim.enabled = true;
    }
}
