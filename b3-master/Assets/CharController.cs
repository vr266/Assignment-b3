using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    public Animator aperson;

    // Start is called before the first frame update
    void Start(){
        aperson=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var x_vel = Input.GetAxis("Horizontal");
        var y_vel = Input.GetAxis("Vertical");

        aperson.SetFloat("x_vel", x_vel);
        aperson.SetFloat("y_vel", y_vel);

    }
}
