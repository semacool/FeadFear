using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMY : MonoBehaviour
{

    private AudioSource Walk;
    Vector3 target_vector;
    public Transform sg_controller;
    public Transform Camera_View;
    public Camera Shake;
    public Transform dog;
    public static float speed;
    public static bool S;
    float strong;
    float fix;
    Vector3 PlayPos = new Vector3(0f, 0f, 0f);
    Vector3 firsttouch_pos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        Walk = GetComponent<AudioSource>();
        S = true;
        speed = 10f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        speed = speed > 10f ? speed -= 0.05f : speed<10f ? speed+=0.05f : 10f;

        if (Input.GetMouseButton(0))
        {
    
            if (Input.GetMouseButtonDown(0)) { firsttouch_pos = Input.mousePosition; }

            Vector3 touch_pos = Input.mousePosition;
           
            target_vector = touch_pos - firsttouch_pos;
           // Debug.Log(target_vector);
            
                if (!Walk.isPlaying) { Walk.Play(); } 
                
                PlayPos += new Vector3(target_vector.x, 0f, target_vector.y).normalized  * Time.deltaTime * speed ;

                PlayPos.x = PlayPos.x > 50f ? 50f : PlayPos.x;  // Ограничение
                PlayPos.x = PlayPos.x < -52f ? -52f : PlayPos.x;  // Ограничение
                PlayPos.z = PlayPos.z > 50f ? 50f : PlayPos.z;  // Ограничение
                PlayPos.z = PlayPos.z < -52f ? -52f : PlayPos.z;   // Ограничение

                sg_controller.position = PlayPos; //Vector3.MoveTowards(sg_controller.position, new Vector3(PlayPos.x, sg_controller.position.y, PlayPos.y), speed * Time.deltaTime); // Движение Персонажа
                
                Camera_View.position = new Vector3(sg_controller.position.x, 7f, sg_controller.position.z); // камера идёт за персонажем
                float angle = AngleBetweenTwoPoints(sg_controller.position,sg_controller.position -firsttouch_pos + Input.mousePosition); // нахождение угла
                sg_controller.rotation = Quaternion.Euler(new Vector3(0f, -angle + 90f, 0)); // поворот

        }
        else
        {
            Walk.Stop();
            sg_controller.position = sg_controller.position; 

        }

        fix = (1f - Vector3.Distance(sg_controller.transform.position, dog.transform.position) / 10f);
        strong = fix < 0f ? 0f : fix;

        Camera_View.rotation = Quaternion.Euler(new Vector3(90f + Random.Range(-strong, strong), 0 + Random.Range(-strong, strong), 0 + Random.Range(-strong, strong)));
        Shake.orthographicSize = 9f - strong * 2f;
    }
    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
