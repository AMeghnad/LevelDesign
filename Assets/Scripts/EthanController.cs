using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EthanController : MonoBehaviour
{
    public Animator anim;
    public bool isMoving;
    [Range(-1,1)]
    public float horizontal, vertical;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isMoving", isMoving);
        anim.SetFloat("Horizontal", horizontal);
        anim.SetFloat("Vertical", vertical);
    }
}
