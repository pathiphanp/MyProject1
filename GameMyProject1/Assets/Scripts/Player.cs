using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] int set;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            set++;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            set = 0;
        }
        anim.SetInteger("AtkSet", set);
    }
}
