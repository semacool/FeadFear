using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingManHP : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GamePlay.heroHP += 2f;
        }

    }

}
