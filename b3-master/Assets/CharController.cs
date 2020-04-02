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
        if(Input.GetKeyDown(KeyCode.Space)){
            aperson.SetFloat("Horizontal",-1);
        }
        else{
            aperson.SetFloat("Horizontal",1);
        }
    }
}
