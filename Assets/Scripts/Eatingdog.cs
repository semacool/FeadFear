using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eatingdog : MonoBehaviour
{
    private AudioSource Audio;
    
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Dogs")
        {
            Destroy(gameObject);
            MoveDog.D = false;
        }

        if (other.gameObject.tag == "Player")
        {
            Audio.Play();
           
            GamePlay.heroHP -= 2f;

            Destroy(gameObject);

        }

    }

    private void Start()
    {
            Audio = GetComponent<AudioSource>();

    }
}
