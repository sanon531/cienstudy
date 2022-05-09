using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Test_Script : MonoBehaviour
{
    Animator _animator; 

    // Start is called before the first frame update
    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _animator.SetBool("move",true);
        } else if (Input.GetKeyUp(KeyCode.Q))
        {
            _animator.SetBool("move", false);
        }

    }
}
