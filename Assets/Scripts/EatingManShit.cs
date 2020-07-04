using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingManShit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            JoystickMY.speed -= 8f;
        }

    }
}
