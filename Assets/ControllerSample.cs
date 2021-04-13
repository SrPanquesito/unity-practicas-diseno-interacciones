using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSample : MonoBehaviour
{
    private Animator _animator;
    public bool gathering = false;
    public bool farming = false;

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gathering)
        {
            _animator.SetBool("Gathering", true);
        }
        else if (!gathering)
        {
            _animator.SetBool("Gathering", false);
        }
        if (farming)
        {
            _animator.SetBool("Farming", true);    
        }
        else if (!farming)
        {
            _animator.SetBool("Farming", false);    
        }
    }
}
