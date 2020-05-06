using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnceAnimation : MonoBehaviour
{
    public Animator animator;
    private void Awake()
    {
        animator.Play("New Animation");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
