using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanController : MonoBehaviour
{
    public Animator animator;
    //public AudioSource scanSound;
    // Start is called before the first frame update
    void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }
    public void Scan()
    {
        animator.SetTrigger("Scan");
    //    if (scanSound != null)
     //       {
    //        scanSound.Play();
    //    }
    }

}