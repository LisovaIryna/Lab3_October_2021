using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Control : MonoBehaviour
{
    void Start()
    {
        Animation anim = GetComponent<Animation>();
        anim.Play("Animation_Lab_3");
    }
}