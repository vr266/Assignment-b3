﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    public Animator aperson;
    //bool jumping = false;


    // Start is called before the first frame update
    void Start(){
        aperson = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var x_vel = Input.GetAxis("Horizontal");
        var y_vel = Input.GetAxis("Vertical");
        var jump = Input.GetAxis("Jump");

        aperson.SetFloat("x_vel", x_vel);
        aperson.SetFloat("y_vel", y_vel);

        if (jump > 0)
        {
            aperson.SetBool("grounded", false);
        } else
        {
            aperson.SetBool("grounded", true);
        }



    }
}
