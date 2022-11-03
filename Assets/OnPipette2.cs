using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPipette2 : MonoBehaviour
{
    public GameObject parent2;
    private void OnMouseDrag()
    {
        var anim = parent2.GetComponent<Animator>();
        anim.enabled = true;
    }
}
