using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaplayer : MonoBehaviour
{
    public GameObject endPoint;
    private Animator playeranim;
    public Transform Hp;
    private void Start()
    {
        playeranim = GetComponent<Animator>();
    }
    void Update()
    {
        Hp.transform.localScale = new Vector3(100f,GamePlay.heroHP * 30f, 1f) ;

        playeranim.SetBool("Runn", false);
        if (Input.GetMouseButton(0))
        {
            playeranim.SetBool("Runn", true);
        }


      
    }
    

   
}
